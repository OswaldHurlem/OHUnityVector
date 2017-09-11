Param()

$scriptPath = split-path -parent $MyInvocation.MyCommand.Definition
pushd $scriptPath

    if (-not ($NoGenerate))
    {
        .\GenerateCode.ps1
    }

    Invoke-Expression "cl.exe oh_vectors_unity_buildtest.cpp"
popd