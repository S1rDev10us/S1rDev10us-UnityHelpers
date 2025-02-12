{
  outputs = {nixpkgs, ...}: let
    allSystems = ["x86_64-linux"];

    forAllSystems = f:
      nixpkgs.lib.genAttrs allSystems (system:
        f {
          pkgs = import nixpkgs {inherit system;};
          inherit system;
        });
  in {devShells = forAllSystems ({pkgs, ...}: {default = pkgs.mkShell {packages = with pkgs; [alejandra tera-cli];};});};
}
