{ pkgs ? import
    (fetchTarball {
      name = "jpetrucciani-2025-03-05";
      url = "https://github.com/jpetrucciani/nix/archive/65b690f3439011524d05e0e612adce59a0db1d4d.tar.gz";
      sha256 = "0fgrzxz9ipi7smb65m3mb42j7mq3v93v3jw4y0ji0pl5sz4nwn44";
    })
    { }
}:
let
  name = "SlackAPI";

  tools = with pkgs; {
    cli = [
      jfmt
      nixup
    ];
    dotnet = [
      clang
      dotnet-sdk_9
      dotnet-runtime_9
      dotnetPackages.Nuget
      netcoredbg
      zlib
    ];
    scripts = pkgs.lib.attrsets.attrValues scripts;
  };

  scripts = with pkgs; { };
  paths = pkgs.lib.flatten [ (builtins.attrValues tools) ];
  env = pkgs.buildEnv {
    inherit name paths; buildInputs = paths;
  };
in
(env.overrideAttrs (_: {
  inherit name;
  NIXUP = "0.0.9";
  DOTNET_CLI_TELEMETRY_OPTOUT = 1;
  DOTNET_ROOT = "${pkgs.dotnet-sdk_9}";
})) // { inherit scripts; }
