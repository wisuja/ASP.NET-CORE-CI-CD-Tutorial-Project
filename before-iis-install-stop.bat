@echo off
REM - File: before-iis-install-stop.bat

echo Restarting IIS...
echo ======================================================

appcmd stop sites "NETCoreWebApp"

echo ======================================================
echo IIS Stopped