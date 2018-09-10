create schema biblioteca

create table biblioteca.livro(
	id_livro serial not null,
	nm_livro varchar(100) not null,
	ds_livro varchar(500) not null,
	st_livro integer not null,

	constraint pk_livro primary key (id_livro)

)

create table biblioteca.cliente(
	id_cliente serial not null,
	nm_cliente varchar(100) not null,
	ra_cliente varchar(10)not null,

	constraint pk_cliente primary key(id_cliente)

)

create table biblioteca.emprestimo(
	id_emprestimo serial not null,
	id_cliente_emprestimo int not null,
	id_livro_emprestimo int not null,
	dt_aluguel_emprestimo timestamp without time zone not null,
	dt_entrega_emprestimo timestamp without time zone not null,
	
	constraint pk_emprestimo primary key (id_emprestimo),
	constraint fk_emprestimo_cliente foreign key (id_cliente_emprestimo) references biblioteca.cliente(id_cliente),
	constraint fk_emprestimo_livro foreign key (id_livro_emprestimo) references biblioteca.livro(id_livro)
	
)

insert into biblioteca.livro(nm_livro, ds_livro, st_livro)
values('O atirador no campo de centeio','O livro narra um fim-de-semana na vida de Holden Caulfield, um jovem de dezessete anos vindo de uma família abastada de Nova Iorque. ','0')

insert into biblioteca.livro(nm_livro, ds_livro, st_livro)
values('O pequeno principe','A história começa com o narrador descrevendo suas recordações, em que aos 6 anos de idade fez um desenho de uma jiboia que havia engolido um elefante.','0')

insert into biblioteca.livro(nm_livro, ds_livro, st_livro)
values('livro as cronicas de narnia o leão a feiticeira e o guarda roupa', 'Neste livro são narradas as aventuras dos quatro irmãos Pevensie: Pedro, Susana, Edmundo e Lúcia, que fugindo dos bombardeios a Londres durante a II Guerra Mundial, vão até a casa de um professor que morava no campo. Lá encontram, dentro de um guarda-roupa (cuja origem é revelada em O Sobrinho do Mago), uma passagem que liga nosso mundo ao mundo de Nárnia.','0')

insert into biblioteca.cliente(nm_cliente, ra_cliente)
values ('Kelven Barbieri', '258963147')

insert into biblioteca.cliente(nm_cliente, ra_cliente)
values ('Jean FullStack C#', '987456321')

insert into biblioteca.cliente(nm_cliente, ra_cliente)
values ('Felipão Developer Cast', '8524147')

select * from biblioteca.cliente

select * from biblioteca.livro
