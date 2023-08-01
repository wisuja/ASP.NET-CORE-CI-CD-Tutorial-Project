@echo off
REM - File: after-iis-install-start.bat 

echo Restarting IIS...
echo ======================================================

net start W3SVC

echo ======================================================
echo IIS Restarted