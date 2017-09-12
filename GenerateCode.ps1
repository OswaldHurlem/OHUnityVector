Param([switch]$Purge)
$scriptPath = split-path -parent $MyInvocation.MyCommand.Definition
pushd $scriptPath

python oh_unity_vector_generator.py

cp *.cs .\TestNew\Assets\ -Force -ErrorAction SilentlyContinue
cp *.cs .\TestOld\Assets\ -Force -ErrorAction SilentlyContinue

popd