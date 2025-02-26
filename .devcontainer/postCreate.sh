dotnet workload install wasm-tools
dotnet workload install wasm-experimental
apt-get update
apt-get install -y python3          # need libpython3-stdlib / shlex.py for Release builds
apt-get clean
