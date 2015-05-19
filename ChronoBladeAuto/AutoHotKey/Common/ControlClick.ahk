;file = FileOpen("ControlClick.txt", "r")
;MsgBox %A_WorkingDir%\ControlClick.txt

FileRead, ClickPoint, %A_WorkingDir%\AutoHotKey\Common\ControlClick.txt
if not ErrorLevel  ; Successfully loaded.
{
	;MsgBox "ClickPoint : " %ClickPoint%

	;ControlClick, %ClickPoint%, BlueStacks App Player,,,1
	ControlClick, %ClickPoint%, BlueStacks App Player,,,1       
}
else
{
	;MsgBox %ErrorLevel%
}




