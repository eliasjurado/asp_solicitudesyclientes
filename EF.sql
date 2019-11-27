use Negocios2018
go

create table tb_solicitud(
idsol int primary key,
fechasol datetime default getdate(),
idcliente varchar(5) references tb_clientes,
detsol varchar(255),
costosol decimal
)
go