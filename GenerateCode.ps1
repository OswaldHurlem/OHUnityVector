Param([switch]$Purge)

$scriptPath = split-path -parent $MyInvocation.MyCommand.Definition
pushd $scriptPath


if ($Purge)
{
    del .\Test\Assets\*.cs -Force -ErrorAction SilentlyContinue
}
else
{
    python oh_unity_vector_generator.py
    cp *.cs .\Test\Assets\ -Force -ErrorAction SilentlyContinue
}

popd