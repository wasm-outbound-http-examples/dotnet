# Use RestSharp library to send HTTP(s) requests from inside WASM in Node.js, Bun, and Deno

## Instructions for this devcontainer

Tested with .Net SDK version 9.0.200, Bun 1.2.4, Deno 2.2.2, Node.js 22.14.0, RestSharp [v112.1.0](https://www.nuget.org/packages/RestSharp/112.1.0).

### Preparation

1. Open this repo in devcontainer, e.g. using Github Codespaces.
   Type or copy/paste following commands to devcontainer's terminal.

### Building

1. `cd` into the folder of this example:

```sh
cd browser-and-node-RestSharp/node
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
node bin/Debug/net9.0/browser-wasm/AppBundle/main.mjs
```

### Test with Bun

1. Install Bun:

```sh
curl -fsSL https://bun.sh/install | bash
```

2. Run with Bun:

```sh
~/.bun/bin/bun bin/Debug/net9.0/browser-wasm/AppBundle/main.mjs
```

### Test with Deno

1. Install Deno:

```sh
curl -fsSL https://deno.land/install.sh | bash -s -- --yes
```

2. Run with Deno:

```sh
~/.deno/bin/deno run --allow-read --allow-net --unstable-bare-node-builtins bin/Debug/net9.0/browser-wasm/AppBundle/main.mjs
```

### Finish

Perform your own experiments if desired.
