Set oShell = CreateObject ("Wscript.Shell") 
Dim strArgs
strArgs = "cmd /c runner.bat"
oShell.Run strArgs, 0, false