# UnblockResxFiles

## Functionality

Removes the 'Mark of Web' error given when trying to open a downloaded visual studio project for the first time. 
This mark can be removed via powershell, but this provides a GUI for a user to upload a full directory.

![image](https://github.com/Cole-Z/UnblockResxFiles/assets/98670265/2b882dca-fcd8-45b8-b374-cb7f4977ae7f)

"Couldn't process file Form1.resx due to its being in the Internet or Restricted Zone or having the make of the web on the file. Remove the mark of the web if you want to process these files."


### Clone project

`git clone https://github.com/Cole-Z/UnblockResxFiles.git`

Build

`dotnet build`

Run

`dotnet run`


## Interface

User can upload a valid solution folder or visual studio project with the 'open dir' button and then select 'Unblock' to start the scan and remove any marks of the web.

![image](https://github.com/Cole-Z/UnblockResxFiles/assets/98670265/389c2422-7381-4a00-af61-307efde6acc2)


If the scan runs with no errors, then the user is presented with a 'complete' notification, and the files should now be ready to be processed.

![image](https://github.com/Cole-Z/UnblockResxFiles/assets/98670265/20473064-e438-4d1e-bfea-4b6feed36f4d)

checking the folder after processing: 

![image](https://github.com/Cole-Z/UnblockResxFiles/assets/98670265/07031103-1a2e-455b-ac21-be8374d6b8a9)

The orginal file can now be processed, as before we were unable to see any other errors.

If a incorrect folder is added, then an error is thrown to the user. In order for a complete scan, the folder must contain '.resx' files

![image](https://github.com/Cole-Z/UnblockResxFiles/assets/98670265/a0c5d369-68aa-4e33-ae47-1470c2b8704d)



