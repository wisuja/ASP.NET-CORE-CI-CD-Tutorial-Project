@echo off
REM - File: after-iis-install-start.bat 

echo Restarting IIS...
echo ======================================================

appcmd start sites "NETCoreWebApp"

echo ======================================================
echo IIS Restarted