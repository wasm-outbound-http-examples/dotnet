# Use .Net / C# to send HTTP(s) requests from inside WASM in Node.js, Bun, and Deno

## Instructions for this devcontainer

Tested with .Net version 8.0.100-rc.2.23502.2 .

### Preparation

1. Open this repo in devcontainer, e.g. using Github Codespaces.
   Type or copy/paste following commands to devcontainer's terminal.


2. Install .Net workloads to handle WASM:

```sh
dotnet workload install wasm-tools
dotnet workload install wasm-experimental
```

### Building

1. `cd` into the folder of this example:

```sh
cd browser-and-node/node
```

2. Create new .Net project using `wasmconsole` template:

```sh
dotnet new wasmconsole
```

3. Replace generated HelloWorld-like `Program.cs` and `main.mjs` with HTTP-enabled ones:

```sh
cp ../Program.cs ./
cp ../main.js ./main.mjs
```

4. Compile the example:

```sh
dotnet build
```

### Test with Node.js

1. Run the configuration:

```sh
dotnet run
```

Or, alternatively, the same by directly using `node` command:

```sh
node bin/Debug/net8.0/browser-wasm/AppBundle/main.mjs
```

### Test with Bun

1. Install Bun:

```sh
curl -fsSL https://bun.sh/install | bash
```

2. Run with Bun:

```sh
~/.bun/bin/bun bin/Debug/net8.0/browser-wasm/AppBundle/main.mjs
```

### Test with Deno

1. Install Deno:

```sh
curl -fsSL https://deno.land/x/install/install.sh | sh
```

2. Run with Deno:

```sh
~/.deno/bin/deno run --allow-read --allow-net bin/Debug/net8.0/browser-wasm/AppBundle/main.mjs
```

You may want adding `Deno.exit();` to the end of `main.mjs`, in the case Deno does not exit after printing to console.

### Finish

Perform your own experiments if desired.
