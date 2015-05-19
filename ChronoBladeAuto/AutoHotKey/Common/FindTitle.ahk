CoordMode, ToolTip, Screen

;MsgBox %A_ScreenWidth% %A_ScreenHeight%
SrnWidth := 3360
;A_ScreenHeight := 1080

FileList =  ; Initialize to be blank.

Loop, %A_WorkingDir%\Images\Title\*.*
    FileList = %FileList%%A_LoopFileName%`n
;MsgBox %A_WorkingDir%\Images\Title\

Loop, parse, FileList, `n
{


	ImageSearch, FoundX, FoundY, 0, 0, %SrnWidth%, %A_ScreenHeight%, %A_WorkingDir%\Images\Title\%A_LoopField%
	if ErrorLevel = 2
	{
		;MsgBox Could not conduct the search.
	}
	else if ErrorLevel = 1
	{
		;MsgBox Icon could not be found on the screen.
	}
	else
	{
		;MsgBox The icon was found at %FoundX%x%FoundY%.
		
		FileRead, Contents, %A_WorkingDir%\AutoHotKey\Common\FindTitle.txt
		if not ErrorLevel  ; Successfully loaded.
		{
			FileDelete, %A_WorkingDir%\AutoHotKey\Common\FindTitle.txt
			FileAppend, %A_LoopField%, %A_WorkingDir%\AutoHotKey\Common\FindTitle.txt
			;Contents =   ; Free the memory.
			;sgBox %A_LoopField%
			break	
		}
		else
		{
			sleep 1000
			;MsgBox %ErrorLevel%
		}
		

	}


    ;if A_LoopField =  ; Ignore the blank item at the end of the list.
        ;continue
    ;MsgBox, 4,, File number %A_Index% is %A_LoopField%.  Continue?
    ;IfMsgBox, No
        ;break
}

