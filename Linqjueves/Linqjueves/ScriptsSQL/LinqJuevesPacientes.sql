--Almacenar
Create procedure SP_Alta
@Inscripcion nvarchar (10),
@Nombre nvarchar (15),
@Apellidos nvarchar(50),
@sexo nvarchar(12),
@Fecha nvarchar(50),
@Direccion nvarchar(50),
@NumSS nvarchar (10)
as 
insert into Pacientes(Inscripci�n,Nombre,Apellidos,sexo,Fecha,Direccion,NumSS)
values(@Inscripcion,@Nombre,@Apellidos,@sexo,@Fecha,@Direccion,@NumSS)
go 

--Modificar
Create procedure SP_ModificarAlta
@Inscripcion nvarchar (10),
@Nombre nvarchar (15),
@Apellidos nvarchar(50),
@sexo nvarchar(12),
@Fecha nvarchar(50),
@Direccion nvarchar(50),
@NumSS nvarchar (10)
as 
update Pacientes
set Inscripci�n=@Inscripcion, Nombre=@Nombre, Apellidos=@Apellidos, sexo=@sexo, Fecha=@Fecha, Direccion=@Direccion, NumSS=@NumSS
where Inscripci�n=@Inscripcion
go


--Eliminar
Create procedure SP_Baja
@Inscripcion nvarchar(10)
as
delete 
from Pacientes
where Inscripci�n=@Inscripcion
go


--Listar
Create procedure SP_ListarAltas
as 
select * 
from Pacientes
go

