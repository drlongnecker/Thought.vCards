$framework = "4.0"

properties { 
  
  # ****************  CONFIGURE **************** 
    $base_directory  = 		resolve-path .
    $solution_name = 		"vCards"
    $solution_file = 		"$base_directory\Solution\$solution_name.sln" 
    
  	$thirdparty_directory = "$base_directory\lib"
    $build_directory = 		"$base_directory\build" 
    $release_directory = 	"$base_directory\release"
	
    $coverage_runner = 		"$base_directory\tools\partcover\partcover.exe"
	$transform_runner = 	"$base_directory\tools\sandcastle\xsltransform.exe"
	$transform_xsl = 		"$base_directory\tools\partcover\PartCoverFullReport.xslt"
} 

task default -depends Release

task Clean { 
  remove-item -force -recurse $build_directory -ErrorAction SilentlyContinue
  remove-item -force -recurse $release_directory  -ErrorAction SilentlyContinue
} 

task Init -depends Clean { 
    new-item $release_directory -itemType directory | Out-Null
    new-item $build_directory -itemType directory | Out-Null
} 

task Compile -depends Init { 
	# adding double slash for directories with spaces. Stupid MSBuild.
	# NoWarn=1591 == suppress documentation warnings.
	exec { msbuild /verbosity:minimal /p:NoWarn=1591 /p:Configuration="Release" /p:Platform="Any CPU" /p:OutDir="$build_directory"\\ "$solution_file" }
} 

task Test -depends Compile {
      " - Executing tests and coverage ..."
      $testExpression = "$coverage_runner --register --settings $base_directory\partcover.xml --output $build_directory\partcover_results.xml"
      exec { invoke-expression $testExpression }
      " - Converting coverage results for $test to HTML report..."
			$coverageExpression = "$transform_runner $build_directory\partcover_results.xml /xsl:$transform_xsl /out:$build_directory\partcover.html"
      exec { invoke-expression $coverageExpression }
}

task Build -depends Compile {
	# When I REALLY don't want to test...
}

task Release -depends Test {
	copy-item -recurse $build_directory\* $release_directory
}
task DeployToTest -depends Release {
	"Deploying to $test_site..."
	remove-item -force -recurse $test_site -ErrorAction SilentlyContinue
	copy-item -recurse $release_directory $test_site
}

task DeployToDev -depends Release {
	"Deploying to $development_site..."
	remove-item -force -recurse $development_site -ErrorAction SilentlyContinue
	copy-item -recurse $release_directory $development_site
}

task DeployToProd -depends Release {
	"Deploying to $production_site..."
	remove-item -force -recurse $production_site -ErrorAction SilentlyContinue
	copy-item -recurse $release_directory $production_site
}
