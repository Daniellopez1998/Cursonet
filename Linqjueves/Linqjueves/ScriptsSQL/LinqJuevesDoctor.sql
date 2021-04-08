--Almacenar
Create procedure SP_AltaDoctor
@Hospital_Cod nvarchar (5),
@Num_Doctor nvarchar (5),
@Apellido nvarchar(15),
@Especialidad nvarchar (20)
as 
insert into Doctor(Hospital_Cod,Número_Doctor,Apellido,Especialidad)
values(@Hospital_Cod,@Num_Doctor,@Apellido,@Especialidad)
go 


--Modificar
Create procedure SP_ModificarDoctor
@Hospital_Cod nvarchar (5),
@Num_Doctor nvarchar (5),
@Apellido nvarchar(15),
@Especialidad nvarchar (20)
as 
update Doctor
set Hospital_Cod=@Hospital_Cod, Número_Doctor=@Num_Doctor, Apellido=@Apellido, Especialidad=@Especialidad
where Hospital_Cod=@Hospital_Cod
go


--Eliminar
Create procedure SP_BajaDoctor
@Hospital_Cod nvarchar (5)
as
delete 
from Doctor
where Hospital_Cod=@Hospital_Cod
go


--Listar
Create procedure SP_ListarDoctor
as 
select * 
from Doctor
go