# Blue-Sky
Proyecto II de Requerimientos de Software

USO DEL REST SERVICE

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

#DeleteAssignation( string idCourse, int numberDelete )
http://blueskytec.azurewebsites.net/api/Assignation?idCourse=()&numberDelete=()


#GetAllNotes( string idCourse, int number )
http://blueskytec.azurewebsites.net/api/Assignation?idCourse=()&number=()


#GetAllStudentNotes( string idStudent, string idCourse ) 
http://blueskytec.azurewebsites.net/api/Assignation?idStudent=()&idCourse=()


#UpdateNote(string idStudent, string idCourse, int number, float grade)
http://blueskytec.azurewebsites.net/api/Assignation?idStudent=()&idCourse=()&number=()&grade=()


#GetAllMessages( string idCourse, string idTeacher, string idStudent ) . Funciona bidireccionalmente
http://blueskytec.azurewebsites.net/api/Assignation?idCourse=()&idTeacher=()&idStudent=()


#SendMessage( string idCourse, string idSender, string idReceiver, string message )
http://blueskytec.azurewebsites.net/api/Assignation?idCourse=()&idSender=()&idReceiver=()%message=()


#GetFinalNotes( string idCourse ) 
http://blueskytec.azurewebsites.net/api/FinalNote?idCourse=IC01160_2016_01


#SummitNotes(string idCourseToSummitNotes)
http://blueskytec.azurewebsites.net/api/FinalNote?idCourse=IC01160_2016_01


#Lista de usuarios disponibles para hacer pruebas
* 2014012340	ABCdef123	Jonathan L. Medina	correo@email.com	Estudiante
* 2014012341	ABCdef123	James H. Anderson	correo@email.com	Estudiante
* 2014012342	ABCdef123	Sebrina J. Brown	correo@email.com	Estudiante
* 2014012343	ABCdef123	Harold P. Villanveva	correo@email.com	Estudiante
* 2014012344	ABCdef123	Joseph B. Soto	correo@email.com	Estudiante
* 2014012345	ABCdef123	Laura G. Dixon	correo@email.com	Estudiante
* 2014012346	ABCdef123	Patricia J. Rupp	correo@email.com	Estudiante
* 2014012347	ABCdef123	Marianne R. Nakamura	correo@email.com	Estudiante
* 2014012348	ABCdef123	Frances D. Brown	correo@email.com	Estudiante
* 2014012349	ABCdef123	Marcia P. Johnson	correo@email.com	Estudiante
* 2015012340	ABCdef123	Ethel W. Taylor	correo@email.com	Estudiante
* 2015012341	ABCdef123	Lisa R. Spell	correo@email.com	Estudiante
* 2015012342	ABCdef123	David B. McGee	correo@email.com	Estudiante
* 2015012343	ABCdef123	Donald M. Boan	correo@email.com	Estudiante
* 2015012344	ABCdef123	Melinda D. Cowles	correo@email.com	Estudiante
* 2015012345	ABCdef123	Elise S. Michael	correo@email.com	Estudiante
* 2015012346	ABCdef123	Vivian C. McKnight	correo@email.com	Estudiante
* 2015012347	ABCdef123	Virginia N. Ridings	correo@email.com	Estudiante
* 2015012348	ABCdef123	Gustavo B. Miller	correo@email.com	Estudiante
* 2015012349	ABCdef123	Bryce K. Fitzgerald	correo@email.com	Estudiante
* 2015082908	123	Andrey Mendoza	andreymendozaf@gmail.com	Estudiante
* 2015114121	asdf	Pablo Navarro Altamirano	Pixarliza@gmail.com	Estudiante
* 2015114132	ABCdef123	Julian Salinas Rojas	july12sali@gmail.com	Profesor
* 2015125414	qwerty	Armando López Cordero	armando12101996@gmail.com	Profesor
* 2016012340	ABCdef123	Diane C. Hernandez	correo@email.com	Estudiante
* 2016012341	ABCdef123	Richard E. Jackson	correo@email.com	Estudiante
* 2016012342	ABCdef123	Nicholas R. Espinoza	correo@email.com	Estudiante
* 2016012343	ABCdef123	Barbara R. Langford	correo@email.com	Estudiante
* 2016012344	ABCdef123	Marian J. Phillips	correo@email.com	Estudiante
* 2016012345	ABCdef123	Jason M. Villalobos	correo@email.com	Estudiante
* 2016012346	ABCdef123	Thomas K. Clayton	correo@email.com	Estudiante
* 2016012347	ABCdef123	John L. Harris	correo@email.com	Estudiante
* 2016012348	ABCdef123	Laura J. Barnwell	correo@email.com	Estudiante
* 2016012349	ABCdef123	Nicole S. Renaud	correo@email.com	Estudiante
* 2016101010	123	Dennis Salinas	calcasalinas@hotmail.es	Estudiante
* 2016101011	123	Karla Rodriguez	kakarla84rr@hotmail.com	Estudiante





