# Blue-Sky
Proyecto II de Requerimientos de Software

USO DEL REST SERVICE

#Obtener la sesion de un usuario por medio de su numero de carnet
#NOTA: este tambien devuelve en el mismo json si se trata de un estudiante o de un profesor
#El primer link es un ejemplo de un estudiante y el segundo el del un profesor
http://blueskytec.azurewebsites.net/api/Login?carnet=2000445560&contrasenha=RDK455
http://blueskytec.azurewebsites.net/api/Login?carnet=2007641672&contrasenha=VLY311

#Obtener todos los cursos que da un determinado profesor
#Dentro de la informacion que posee cada curso tambien estan los estudiantes quiene lo reciben
http://blueskytec.azurewebsites.net/api/Curso?idProfesor=2007641672

