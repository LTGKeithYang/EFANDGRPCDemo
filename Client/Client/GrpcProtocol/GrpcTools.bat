setlocal

@rem enter this directory
cd /d %~dp0

set TOOLS_PATH=C:\Users\KeithYang\.nuget\packages\grpc.tools\1.15.0\tools\windows_x64

%TOOLS_PATH%\protoc.exe ./Grpc.proto  --csharp_out ./  --grpc_out ./ --plugin=protoc-gen-grpc=%TOOLS_PATH%\grpc_csharp_plugin.exe

pause

endlocal
