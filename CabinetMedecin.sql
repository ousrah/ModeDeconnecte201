create database cabinetMedecin;
use cabinetMedecin;


create table medecin(id int identity primary key, nom varchar(50) not null, prenom varchar(50), email varchar(50) not null, telephone varchar(50) not null);

create table medicament(id int identity primary key, nom varchar(50) not null);

create table patient(id int identity primary key, nom varchar(50) not null, prenom varchar(50), email varchar(50) not null, telephone varchar(50) not null);

create table consultation(id  int identity primary key, idMedecin int foreign key references medecin(id), idPatient int foreign key references patient(id),dateConsultation date,observation text)

create table ordonance (idConsultation int foreign key references consultation(id), idMedicament  int foreign key references medicament(id), observation varchar(255))

create table utilisateur (login varchar(50) primary key, password varchar(50), dateInscription date, dateExpiration date, role varchar(50));




insert into utilisateur values ('m1','123456','10/10/2010',null,'medecin');
insert into utilisateur values ('s1','123456','10/10/2010',null,'secretaire');

insert into medecin values ('nom1','prenom1','med1@cab.com','0602050302')
insert into medecin values ('nom2','prenom2','med2@cab.com','0602050303')
insert into medecin values ('nom3','prenom3','med3@cab.com','0602050304')

insert into patient values ('pat1','pat1prenom1','pat1@cab.com','0602050302')
insert into patient values ('pat2','pat2prenom2','pat2@cab.com','0602050303')
insert into patient values ('pat3','pat2prenom3','pat3@cab.com','0602050304')

insert into consultation values (1,1,'10/01/2021','');
insert into consultation values (1,2,'14/01/2021','');
insert into consultation values (1,3,'13/01/2021','');
insert into consultation values (2,2,'11/01/2021','');
insert into consultation values (3,1,'19/01/2021','');
insert into consultation values (3,2,'20/01/2021','');
insert into consultation values (3,1,'15/01/2021','');


