-- Creacion de las tablas

create table Computadora
(
	IdComputadora int primary key identity,
	IdModelo int not null,
	IdCapMemoriaRam int not null,
	CapDiscoDuro nvarchar(10) not null,
	IdTarjetaVideo int not null,
	IdTipoUnidadOptica int not null,
	Disponible bit not null,
	Constraint Fk_Computadora_Modelo foreign key(IdModelo) references Modelo(IdModelo),
	Constraint Fk_Computadora_CapMemoriaRam foreign key(IdCapMemoriaRam) references CapMemoriaRam(IdCapMemoriaRam),
	Constraint Fk_Computadora_TarjetaVideo foreign key(IdTarjetaVideo) references TarjetaVideo(IdTarjetaVideo),
	Constraint Fk_Computadora_TipoUnidadOptica foreign key(IdTipoUnidadOptica) references TipoUnidadOptica(IdTipoUnidadOptica)
)

create table Modelo
(
	IdModelo int primary key identity,
	Modelo nvarchar(50) not null unique,
	IdMarca int not null
	constraint Fk_IdModelo_IdMarca foreign key(IdMarca) references Marca(IdMarca)
)

create table Marca
(
	IdMarca int primary key identity,
	Marca nvarchar(50) not null unique
)

create table CapMemoriaRam
(
	IdCapMemoriaRam int primary key identity,
	CapacidadMemoria nvarchar(10)
)

create table TarjetaVideo
(
	IdTarjetaVideo int primary key identity,
	TarjetaVideo nvarchar(50) not null unique,
	Capacidad nvarchar(10) not null
)

create table TipoUnidadOptica
(
	IdTipoUnidadOptica int primary key identity,
	UnidadOptica nvarchar(50) not null unique
)

create table TipoPrograma
(
	IdTipoPrograma int primary key identity,
	TipoPrograma nvarchar(100) not null unique
)

Create table Programas
(
	IdPrograma int primary key identity,
	NombrePrograma nvarchar(100) not null,
	IdTipoPrograma int not null,
	constraint Fk_Programas_TipoPrograma foreign key(IdTipoPrograma) references TipoPrograma(IdTipoPrograma)
)

create table TipoLicencia
(
	IdTipoLicencia int primary key identity,
	TipoLicencia nvarchar(150) not null unique
)

alter table Programas add
	IdTipoLicencia int not null,
	constraint Fk_Programas_TipoLicencia foreign key(IdTipoLicencia) references TipoLicencia(IdTipoLicencia)

create table Empleado
(
	IdEmpleado int primary key identity,
	Nombres nvarchar(100) not null,
	Apellidos nvarchar(100) not null,
	NombreUsuario nvarchar(50) not null unique,
	Contraseña nvarchar(50) not null,
	IdSexo int not null,
	Direccion nvarchar(300) not null,
	Telefono char(9),
	Correo nvarchar(100),
	constraint Fk_Empleado_Sexo foreign key(IdSexo) references Sexo(IdSexo)
)

create table Sexo
(
	IdSexo int primary key identity,
	Sexo nvarchar(50) not null unique
)

Create table ProgramaComputadora
(
	IdProgramaComputadora int primary key identity,
	IdPrograma int not null,
	IdComputadora int not null,
	IdEmpleado int not null,
	FechaInstalacion date not null,
	FechaVencimientoLicencia date not null
	constraint Fk_ProgramaComputadora_Programas foreign key(IdPrograma) references Programas(IdPrograma),
	constraint Fk_ProgramaComputadora_Computadora foreign key(IdComputadora) references Computadora(IdComputadora),
	constraint Fk_ProgramaComputadora_Empleado foreign key(IdEmpleado) references Empleado(IdEmpleado)
)

-- Creacion de los Procedimientos almacenados

Create Procedure Sp_AgregarComputadora
@IdModelo int, @IdCapMemoriaRam int, @CapDiscoDuro nvarchar(10), @IdTarjetaVideo int, @IdTipoUnidadOptica int, @Disponible bit
as
	set nocount on
	insert into Computadora
	values(@IdModelo, @IdCapMemoriaRam, @CapDiscoDuro, @IdTarjetaVideo, @IdTipoUnidadOptica, @Disponible)
go

Create Procedure Sp_EditarComputadora
@IdComputadora int, @IdModelo int, @IdCapMemoriaRam int, @CapDiscoDuro nvarchar(10), @IdTarjetaVideo int, @IdTipoUnidadOptica int, @Disponible bit
as
	set nocount on
	update Computadora set IdModelo = @IdModelo, IdCapMemoriaRam = @IdCapMemoriaRam, CapDiscoDuro = @CapDiscoDuro, IdTarjetaVideo = @IdTarjetaVideo, IdTipoUnidadOptica = @IdTipoUnidadOptica, Disponible = @Disponible
	where IdComputadora = @IdComputadora
go

Create Procedure Sp_EliminarComputadora
@IdComputadora int
as
	set nocount on
	delete from Computadora
	where IdComputadora = @IdComputadora
go

Create Procedure Sp_AgregarEmpleado
@Nombres nvarchar(100), @Apellidos nvarchar(100), @NombreUSuario nvarchar(50), @Contraseña nvarchar(50), @IdSexo int, @Direccion nvarchar(300), @Telefono char(9), @Correo nvarchar(100)
as
	set nocount on
	insert into Empleado
	values(@Nombres, @Apellidos, @NombreUSuario, @Contraseña, @IdSexo, @Direccion, @Telefono, @Correo)
go

Create Procedure Sp_EditarEmpleado
@IdEmpleado int, @Nombres nvarchar(100), @Apellidos nvarchar(100), @NombreUSuario nvarchar(50), @Contraseña nvarchar(50), @IdSexo int, @Direccion nvarchar(300), @Telefono char(9), @Correo nvarchar(100)
as
	set nocount on
	update Empleado set Nombres = @Nombres, Apellidos = @Apellidos, NombreUsuario = @NombreUSuario, Contraseña = @Contraseña, IdSexo = @IdSexo, Direccion = @Direccion, Telefono = @Telefono, Correo = @Correo
	where IdEmpleado = @IdEmpleado
go

Create Procedure Sp_EliminarEmpleado
@IdEmpleado int
as
	set nocount on
	delete from Empleado
	where IdEmpleado = @IdEmpleado
go

Create Procedure Sp_AgregarPrograma
@NombrePrograma nvarchar(100), @IdTipoPrograma int, @IdTipoLicencia int
as
	set nocount on
	insert into Programas
	values(@NombrePrograma, @IdTipoPrograma, @IdTipoLicencia)
go

Create Procedure Sp_EditarPrograma
@IdPrograma int, @NombrePrograma nvarchar(100), @IdTipoPrograma int, @IdTipoLicencia int
as
	set nocount on
	update Programas set NombrePrograma = @NombrePrograma, IdTipoPrograma = @IdTipoPrograma, IdTipoLicencia = @IdTipoLicencia
	where IdPrograma = @IdPrograma
go

Create Procedure Sp_EliminarPrograma
@IdPrograma int
as
	set nocount on
	delete from Programas
	where IdPrograma = @IdPrograma
go

Create Procedure Sp_AgregarProgramaComputadora
@IdPrograma int, @IdComputadora int, @IdEmpleado int, @FechaInstalacion date, @FechaVencimientoLicencia date
as
	set nocount on
	insert into ProgramaComputadora
	values(@IdPrograma, @IdComputadora, @IdEmpleado, @FechaInstalacion, @FechaVencimientoLicencia)
go

Create Procedure Sp_EditarProgramaComputadora
@IdProgramaComputadora int, @IdPrograma int, @IdComputadora int, @IdEmpleado int, @FechaInstalacion date, @FechaVencimientoLicencia date
as
	set nocount on
	update ProgramaComputadora set IdPrograma = @IdPrograma, IdComputadora = @IdComputadora, IdEmpleado = @IdEmpleado, FechaInstalacion = @FechaInstalacion, FechaVencimientoLicencia = @FechaVencimientoLicencia
	where IdProgramaComputadora = @IdProgramaComputadora
go

Create Procedure Sp_EliminarProgramaComputadora
@IdProgramaComputadora int
as
	set nocount on
	delete from ProgramaComputadora
	where IdProgramaComputadora = @IdProgramaComputadora
go

-- Insersion de datos en las tablas catalogo

insert into Marca
values ('Apple'),
('Dell'),
('HP')


insert into Modelo
values ('Mac Book Pro', '1'),
('Inspiron','2'),
('EliteBook 725','3')

insert into Sexo
values ('Femenino'),
('Masculino')

insert into TarjetaVideo
values ('Nvidia','8gb'),
('Amd Radeon', '4Gb'),
('Intel Graphics','2Gb')

insert into TipoLicencia
values ('Gratuita'),
('Comprada')

insert into TipoUnidadOptica
values('Ninguno'),
('DVD'),
('CD'),
('DVD/CD'),
('BlueRay')

insert into CapMemoriaRam
values ('4Gb'),
('8Gb'),
('16Gb'),
('32Gb')

insert into TipoPrograma
values ('Programa de sistemas'),
('Programa de Tiempo Real'),
('Programa de Gestion'),
('Programa de Ingenieria y Cientifico'),
('Programa de Empotrado'),
('Programa de Computadoras Personales'),
('Programas Basados en la Web'),
('Programas de Inteligencia Artificial')


Exec Sp_AgregarEmpleado 'Erick', 'Reyes', 'ReyesErick', '1234', 2, 'UNICAH', '9999-9999', 'ejemplo@unicah.com'

Create Procedure Sp_MostrarComputadoras
as
	set nocount on
	select a.IdComputadora, c.Marca, b.Modelo, d.CapacidadMemoria, a.CapDiscoDuro, e.TarjetaVideo, e.Capacidad, f.UnidadOptica, a.Disponible
	from Computadora a inner join Modelo b on a.IdModelo = b.IdModelo
	inner join Marca c on b.IdMarca = c.IdMarca
	inner join CapMemoriaRam d on a.IdCapMemoriaRam = d.IdCapMemoriaRam
	inner join TarjetaVideo e on e.IdTarjetaVideo = a.IdTarjetaVideo
	inner join TipoUnidadOptica f on a.IdTipoUnidadOptica = f.IdTipoUnidadOptica
go


alter Procedure Sp_MostrarModelo
	@IdMarca int
as
BEGIN
	set nocount on
	Select *
	from Modelo
	where Idmarca = @IdMarca
END

go

Create Procedure Sp_MostrarMarca
as
	set nocount on
	Select * from Marca
go

Create Procedure Sp_MostrarCapMemoriaRam
as
	set nocount on
	Select * from CapMemoriaRam
go

Create Procedure Sp_MostrarTarjetaVideo
as
	set nocount on
	Select * from TarjetaVideo
go

Create Procedure Sp_MostrarTipoUnidadOptica
as
	set nocount on
	Select * from TipoUnidadOptica
go

Alter Procedure Sp_MostrarEmpleados
as
	set nocount on
	select a.IdEmpleado, a.Nombres, a.Apellidos, a.NombreUsuario, a.Contraseña, b.Sexo, a.Direccion, a.Telefono, a.Correo
	From Empleado a inner join Sexo b on a.IdSexo = b.IdSexo
go

Create Procedure Sp_MostrarSexo
as
	set nocount on
	select * from Sexo
go

Create Procedure Sp_MostrarTipoPrograma
as
	set nocount on
	select * from TipoPrograma
go

Create Procedure Sp_MostrarTipoLicencia
as
	set nocount on
	select * from TipoLicencia
go

Create Procedure Sp_MostrarProgramas
as
	set nocount on
	select a.IdPrograma, a.NombrePrograma, b.TipoPrograma, c.TipoLicencia
	from Programas a inner join TipoPrograma b on a.IdTipoPrograma = b.IdTipoPrograma
	inner join TipoLicencia c on a.IdTipoLicencia = c.IdTipoLicencia
go

alter Procedure Sp_MostrarProgramasComputadora
@IdComputadora int
as
	set nocount on
	select a.IdProgramaComputadora, b.IdPrograma, b.NombrePrograma, c.TipoPrograma, d.TipoLicencia, e.NombreUsuario, a.FechaInstalacion, a.FechaVencimientoLicencia
	from ProgramaComputadora a inner join Programas b on a.IdPrograma = b.IdPrograma
	inner join TipoPrograma c on b.IdTipoPrograma = c.IdTipoPrograma
	inner join TipoLicencia d on b.IdTipoLicencia = d.IdTipoLicencia
	inner join Empleado e on a.IdEmpleado = e.IdEmpleado
	where IdComputadora = @IdComputadora
go


Create Procedure Sp_MostrarIdComputadoras
@IdComputadora int
as
	set nocount on
	select a.IdComputadora, c.Marca, b.Modelo, d.CapacidadMemoria, a.CapDiscoDuro, e.TarjetaVideo, e.Capacidad, f.UnidadOptica, a.Disponible
	from Computadora a inner join Modelo b on a.IdModelo = b.IdModelo
	inner join Marca c on b.IdMarca = c.IdMarca
	inner join CapMemoriaRam d on a.IdCapMemoriaRam = d.IdCapMemoriaRam
	inner join TarjetaVideo e on e.IdTarjetaVideo = a.IdTarjetaVideo
	inner join TipoUnidadOptica f on a.IdTipoUnidadOptica = f.IdTipoUnidadOptica
	where IdComputadora = @IdComputadora
go

