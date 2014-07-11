; Script generated by the Inno Setup Script Wizard.
; SEE THE DOCUMENTATION FOR DETAILS ON CREATING INNO SETUP SCRIPT FILES!

[Setup]
AppName=Appoteka
AppVerName=Appoteka 2
AppPublisher=OzbiljniLjudi Corp.
AppPublisherURL=http://www.mycompany.com
AppSupportURL=http://www.mycompany.com
AppUpdatesURL=http://www.mycompany.com
DefaultDirName={pf}\Appoteka
DefaultGroupName=Appoteka
Compression=lzma
SolidCompression=yes

[Tasks]
Name: "desktopicon"; Description: "{cm:CreateDesktopIcon}"; GroupDescription: "{cm:AdditionalIcons}"; Flags: unchecked

[Files]
Source: "C:\Program Files (x86)\Inno Setup 5\Examples\MyProg.exe"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\ADMIN\Desktop\setup.exe"; DestDir: "{app}"; Flags: ignoreversion
; NOTE: Don't use "Flags: ignoreversion" on any shared system files

[Icons]
Name: "{group}\Appoteka"; Filename: "{app}\MyProg.exe"
Name: "{userdesktop}\Appoteka"; Filename: "{app}\MyProg.exe"; Tasks: desktopicon

[Run]
Filename: "{app}\MyProg.exe"; Description: "{cm:LaunchProgram,Appoteka}"; Flags: nowait postinstall skipifsilent
