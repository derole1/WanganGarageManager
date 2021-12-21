@echo off

@echo このウィンドウを終了しないでください。

setlocal enabledelayedexpansion

Set INIFILE=monitor_profile.ini
call :GET_INI "WMMT5 SETTINGS" "NICKNAME" INI_GET_TEST %INIFILE%

cd sv\%INI_GET_TEST%\cars
ren *.bin *.car

cd ..\
cd ..\
cd ..\

call WanganGarageManager.edt

cd sv\%INI_GET_TEST%\cars

ren *.car *.bin

endlocal
exit

:GET_INI

set TempStr=
set SN=
for /f "usebackq eol=; delims== tokens=1,2" %%a in (%4) do (
   set V=%%a&set P=!V:~0,1!!V:~-1,1!&set S=!V:~1,-1!
   if "!P!"=="[]" set SN=!S!
   if "!SN!"=="%~1" if "!V!"=="%~2" (
      set TempStr=%%b
      goto GET_INI_EXIT
   )
)

set TempStr=ERR

:GET_INI_EXIT

set %3=%TempStr%
 
:EOF



