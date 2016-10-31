# Blue-Sky
Proyecto II de Requerimientos de Software

USO DEL REST SERVICE

##Datos personales para hacer pruebas 
#'2015114132','ABCdef123','Julian Salinas Rojas', 'july12sali@gmail.com','Profesor'.
#'2015125414','ABCdef123','Armando López Cordero', 'armando12101996@gmail.com','Profesor'.
#'2015114121','ABCdef123','Pablo Navarro Altamirano', 'Pablonavarro2015114121@gmail.com','Estudiante'.


#GetUserSession( string idUser, string password )
http://blueskytec.azurewebsites.net/api/Login?idUser=()&password=()


#UpdatePassword( string idUser, string oldpass, string newpass )
http://blueskytec.azurewebsites.net/api/Login?idUser=()&oldpass=()&newpass=()


#GetAllCourses( string idUser )
http://blueskytec.azurewebsites.net/api/Course?idUser=()


#GetAllStudents( string idCourse )
http://blueskytec.azurewebsites.net/api/Course?idCourse=()


#InsertStudent( string idCourse, string idStudentInsert )
http://blueskytec.azurewebsites.net/api/Course?idCourse=()&idStudentInsert=()


#DeleteStudent( string idCourse, string idStudentDelete )
http://blueskytec.azurewebsites.net/api/Course?idCourse=()&idStudentDelete=()


#GetAllAssignments( string idCourse )
http://blueskytec.azurewebsites.net/api/Assignation?idCourse=()


#InsertAssignation( string idCourse, string title, string type, string delivery, string deliverymeans, float percentage, string description) .El type es si es indidual o en grupos.
http://blueskytec.azurewebsites.net/api/Assignation?idCourse=()&title=()&type=()&delivery=()&deliverymeans=()&percentage=()&description=()


#UpdateAssignation(string idCourse, int number, string title, string type, string delivery, string deliverymeans, float percentage, string description ) 
http://blueskytec.azurewebsites.net/api/Assignation?idCourse=()&number=()&title=()&type=()&delivery=()&deliverymeans=()&percentage=()&description=()

#DeleteAssignation( string idCourse, int numberDelete ) -- esta fallando
http://blueskytec.azurewebsites.net/api/Assignation?idCourse=()&numberDelete=()


#GetAllNotes( string idCourse, int number )
http://blueskytec.azurewebsites.net/api/Assignation?idCourse=()&number=()


#GetAllStudentNotes( string idStudent, string idCourse ) 
http://blueskytec.azurewebsites.net/api/Assignation?idStudent=()&idCourse=()


#UpdateNote(string idStudent, string idCourse, int number, float percentage)
http://blueskytec.azurewebsites.net/api/Assignation?idStudent=()&idCourse=()&number=()&percentage=()





