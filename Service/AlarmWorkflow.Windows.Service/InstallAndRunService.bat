@echo Uninstall service ...
installutil /u AlarmWorkflow.Windows.Service.exe

@echo Install service ...
installutil AlarmWorkflow.Windows.Service.exe
@echo Run service ...
net start AlarmworkflowService

pause