# Blue-Sky
Proyecto II de Requerimientos de Software

USO DEL REST SERVICE

#CreateUser(name,password,email, role) 
*Poner el rol empezando con mayuscula
*El carnet se genera solo
http://blueskytec.azurewebsites.net/api/Login?name=Esteban Quito&password=123&email=esteban123@example.com&role=Estudiante

#GetUserSession(idUser,password )
http://blueskytec.azurewebsites.net/api/Login?idUser=()&password=()


#UpdatePassword( idUser, oldpass, newpass )
http://blueskytec.azurewebsites.net/api/Login?idUser=()&oldpass=()&newpass=()


#GetAllCourses( idUser )
http://blueskytec.azurewebsites.net/api/Course?idUser=()


#GetAllStudents( idCourse )
http://blueskytec.azurewebsites.net/api/Course?idCourse=()


#InsertStudent( idCourse, idStudentInsert )
http://blueskytec.azurewebsites.net/api/Course?idCourse=()&idStudentInsert=()


#DeleteStudent( idCourse, idStudentDelete )
http://blueskytec.azurewebsites.net/api/Course?idCourse=()&idStudentDelete=()


#GetAllAssignments( idCourse )
http://blueskytec.azurewebsites.net/api/Assignation?idCourse=()


#InsertAssignation(idCourse, title, type, delivery, deliverymeans, percentage, description)
http://blueskytec.azurewebsites.net/api/Assignation?idCourse=()&title=()&type=()&delivery=()&deliverymeans=()&percentage=()&description=()


#UpdateAssignation(idCourse, number, title, type, delivery, deliverymeans, percentage, description ) 
http://blueskytec.azurewebsites.net/api/Assignation?idCourse=()&number=()&title=()&type=()&delivery=()&deliverymeans=()&percentage=()&description=()

#DeleteAssignation( idCourse, numberDelete )
http://blueskytec.azurewebsites.net/api/Assignation?idCourse=()&numberDelete=()


#GetAllNotes( idCourse, number )
http://blueskytec.azurewebsites.net/api/Assignation?idCourse=()&number=()


#GetAllStudentNotes( idStudent, idCourse ) 
http://blueskytec.azurewebsites.net/api/Assignation?idStudent=()&idCourse=()


#UpdateNote(idStudent, idCourse, number, grade)
http://blueskytec.azurewebsites.net/api/Assignation?idStudent=()&idCourse=()&number=()&grade=()


#GetAllMessages( idCourse, idTeacher, idStudent ) . Funciona bidireccionalmente
http://blueskytec.azurewebsites.net/api/Message?idCourse=IC01160_2016_01&idTeacher=2015114132&idStudent=2015114121


#SendMessage( idCourse, idSender, idReceiver, message )
http://blueskytec.azurewebsites.net/api/Message?idCourse=IC01160_2016_01&idSender=2015114121&idReceiver=2015114132&message=()


#GetFinalNotes( idCourse ) 
http://blueskytec.azurewebsites.net/api/FinalNote?idCourse=IC01160_2016_01


#SummitNotes(  idCourseToSummitNotes )
http://blueskytec.azurewebsites.net/api/FinalNote?idCourseToSummitNotes=IC01160_2016_01


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
* 2015125414	qwerty	Armando LÃ³pez Cordero	armando12101996@gmail.com	Profesor
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







JULIÁN LOCA..