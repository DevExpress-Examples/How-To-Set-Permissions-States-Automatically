;#DropDB SecuritySetStateEasyTest

#Application SecuritySetStateWin
#Application SecuritySetStateWeb

*FillForm
 User Name = Admin
*Action Log In

#IfDef SecuritySetStateWin

*Action About...
 
*Action OK

#EndIf

#IfDef SecuritySetStateWeb
*Action Navigation(My Details)
#EndIf
