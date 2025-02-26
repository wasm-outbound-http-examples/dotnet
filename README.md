# Make HTTP requests from inside WASM in C# / .Net

This devcontainer is configured to provide you a DotNet SDK 9.0 (with installed workloads `wasm-tools` and `wasm-experimental`) 
and the latest version of Node.js.

[![Open in GitHub Codespaces](https://github.com/codespaces/badge.svg)](https://codespaces.new/wasm-outbound-http-examples/dotnet)

### Browser / JS runtime Examples

<table>
<tr>
<th>#</th>
<th>Example</th>
<th>Description</th>
<th>Browser demo</th>
</tr>
<tr>
<td>1</td>
<td>

[System.Net.Http.HttpClient for browser](browser-and-node/browser/README.md)

</td>
<td>

Use `HttpClient` from standard library to send HTTP requests from web browser.

</td>
<td>

[Demo](https://wasm-outbound-http-examples.github.io/dotnet/)

</td>
</tr>
<tr>
<td>2</td>
<td>

[System.Net.Http.HttpClient for Node / Bun / Deno](browser-and-node/node/README.md)

</td>
<td>

Use `HttpClient` from standard library to send HTTP requests from standalone / server-side JS runtime.

</td>
<td>
</td>
</tr>
<tr>
<td>3</td>
<td>

[RestSharp for browser](browser-and-node-RestSharp/browser/README.md)

</td>
<td>

Use RestSharp library to send HTTP requests from web browser.

</td>
<td>

[Demo](https://wasm-outbound-http-examples.github.io/dotnet/restsharp/)

</td>
</tr>
<tr>
<td>4</td>
<td>

[RestSharp for Node / Bun / Deno](browser-and-node-RestSharp/node/README.md)

</td>
<td>

Use RestSharp library to send HTTP requests from standalone / server-side JS runtime.

</td>
<td>
</td>
</tr>
</table>

<sub>Created for (wannabe-awesome) [list](https://github.com/vasilev/HTTP-request-from-inside-WASM)</sub>
