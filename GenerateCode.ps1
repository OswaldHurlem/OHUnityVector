Param([switch]$Purge)
$scriptPath = split-path -parent $MyInvocation.MyCommand.Definition
pushd $scriptPath

python oh_unity_vector_generator.py

cp .\UnityVector*.cs .\TestNew\Assets\ -Force -ErrorAction SilentlyContinue
cp .\UnityVector*.cs .\TestOld\Assets\ -Force -ErrorAction SilentlyContinue

popd