# QR Code generator app

This is a URL **QR** code generation console application. 

![Eva_Capture377954193](https://github.com/CSharpTeoMan911/QR_Code_Gen/assets/87245086/38c0cda7-9e9d-426f-8c70-bb7c10bc4781)

![Eva_Capture136867287](https://github.com/CSharpTeoMan911/QR_Code_Gen/assets/87245086/f057a106-3efa-49dc-bf8a-3889ff9fb8f1)

![Eva_Capture213194871](https://github.com/CSharpTeoMan911/QR_Code_Gen/assets/87245086/d817ec82-60b1-4239-b6fc-07c3074ee5d7)

![Eva_Capture301133066](https://github.com/CSharpTeoMan911/QR_Code_Gen/assets/87245086/526ac92b-8a8e-4b95-acfd-ab4fc14f5e16)

<br>
<br>

![QR Code](https://github.com/CSharpTeoMan911/QR_Code_Gen/assets/87245086/cd8b4de5-bbcc-4743-9a7b-5722391ebc22)

<br>
<br>
<br>
<br>

# Instalation

Download one of the OS specific releases from the **Releases** section

![Eva_Capture753835735](https://github.com/CSharpTeoMan911/QR_Code_Gen/assets/87245086/fb62f137-dad4-443f-9839-48ad63d6f96c)

![Eva_Capture42615674](https://github.com/CSharpTeoMan911/QR_Code_Gen/assets/87245086/aab6e548-7032-493c-8730-6d5e94a1bc8d)

## Add application to path

### Windows
* Open PowerShell

![Eva_Capture1498827744](https://github.com/CSharpTeoMan911/QR_Code_Gen/assets/87245086/5be3f33b-d807-4d5d-ab63-1eca1f35042c)

* Add the patn to QR.exe as an environment variable
  
```
$PATH = [Environment]::GetEnvironmentVariable("PATH")
$QR_path = "C:\Path_To_QR.exe"
[Environment]::SetEnvironmentVariable("PATH", "$PATH;$QR_path")
```

### Linux
* Open Bash

![Eva_Capture1169422280](https://github.com/CSharpTeoMan911/QR_Code_Gen/assets/87245086/52e69e24-d95d-4f86-be96-ba68b3c6b609)

* Open the **bash.bashrc** file
* Add the PATH to the QR executable file
```
export PATH=$PATH:/etc/Other_Path:/etc/Path_To_QR_Code_Generator
```




