##########################
#######MISSION 1##########
##########################
------
------TO DO --VOIR création package "pckCreation" pour donner ensuite les droits à employe mdl(plus simple pour le futur) + synonyme
------

/*
#Tâche 1 : Contrainte sur les dates
-- On peut utiliser une contrainte check, ou encore un trigger.
-- Nous préférerons ici, utiliser le check.
*/
--création de quelques ateliers
insert into atelier (id, libelleatelier, nbplacesmaxi) values(1, 'atelier water polo', 10);
insert into atelier (id, libelleatelier, nbplacesmaxi) values(2, 'atelier Hockey', 20);
insert into atelier (id, libelleatelier, nbplacesmaxi) values(seqatelier.nextval, 'atelier Lutte', 40);


ALTER TABLE vacation
ADD CONSTRAINT chk_date_sup
  CHECK (heurefin > heuredebut);
--test du check
insert into vacation (idatelier, numero, heuredebut, heurefin) values(3, 9, TO_DATE('12/09/2015 09:02:44', 'dd/mm/yyyy hh24:mi:ss'), TO_DATE('13/09/2015 09:02:44', 'dd/mm/yyyy hh24:mi:ss'));
insert into vacation (idatelier, numero, heuredebut, heurefin) values(1, 2, TO_DATE('13/09/2015 09:02:44', 'dd/mm/yyyy hh24:mi:ss'), TO_DATE('13/09/2015 09:00:44', 'dd/mm/yyyy hh24:mi:ss'));


/*
#Tâche 2 : Gestion des ajouts et mises à jour
--
*/

/*ALTER SEQUENCE seqatelier INCREMENT BY 1;
select seqatelier.nextval from dual;*/

--#Procédure pour l'insertion d'une ligne dans la table atelier.

create or replace procedure ins_atelier( pLibelleAtelier IN atelier.libelleatelier%type := 'Atelier non nommé', pNbPlacesMaxi IN atelier.nbplacesmaxi%type)
IS
dup_val_on_index exception;
exnull exception;
PRAGMA EXCEPTION_INIT ( exnull, - 1400 ) ;

BEGIN
insert into atelier (id, libelleatelier, nbplacesmaxi) values(seqatelier.nextval, pLibelleAtelier, pNbPlacesMaxi);

EXCEPTION
  when exnull then
    raise_application_error(-20099, 'Affectation null à un champs not null');
    
 when dup_val_on_index then
    raise_application_error(-20009, 'Duplication de clé primaire');
    
  when others then
    raise_application_error(-20001, 'Erreur');
END;
/
--création d'un synonyme temporaire (suite au package)
create public synonym ins_atelier for INS_ATELIER;

--test des différents champs.
call ins_atelier('Atelier baston', 50);
call ins_atelier('', 50);
call ins_atelier('Atelier foot', '');

--#Procédure pour l'insertion d'une ligne dans la table theme.

create or replace procedure ins_theme( pIdAtelier IN theme.idatelier%type, pNumero IN theme.numero%type, pLibelleTheme IN theme.libelletheme%type)
IS
dup_val_on_index exception;
exnull exception;
PRAGMA EXCEPTION_INIT ( exnull, -1400 ) ;

BEGIN
insert into theme (idatelier, numero, LIBELLETHEME) values(pIdAtelier, pNumero, pLibelleTheme);

EXCEPTION
  when exnull then
    raise_application_error(-20099, 'Affectation null à un champs not null');
    
 when dup_val_on_index then
    raise_application_error(-20009, 'Duplication de clé primaire');
    
  when others then
    raise_application_error(-20001, 'Erreur');
END;
/

--test des insertion (voirnull, duplication etc ...)
call ins_theme(3,3,'theme 1');
call ins_theme(null,3,'theme 1');
call ins_theme(3,null,'theme 1');
call ins_theme(3,3,null);
call ins_theme(3,5,'theme 2');
--#Procédure pour l'insertion d'une ligne dans la table theme.

create or replace procedure ins_vacation( pIdAtelier IN vacation.idatelier%type, pNumero IN vacation.numero%type, pHeureDebut IN VACATION.HEUREDEBUT%TYPE, pHeureFin IN VACATION.HEUREFIN%type)
IS
dup_val_on_index exception;
exnull exception;
PRAGMA EXCEPTION_INIT ( exnull, -1400 ) ;

BEGIN
insert into vacation(idatelier, numero, HEUREDEBUT, HEUREFIN) values(pIdAtelier, pNumero, pHeureDebut, pHeureFin);

EXCEPTION
  when exnull then
    raise_application_error(-20099, 'Affectation null à un champs not null');
    
 when dup_val_on_index then
    raise_application_error(-20009, 'Duplication de clé primaire');
    
  /*when others then
    raise_application_error(-20001, 'Erreur');*/
END;
/
-- voir si on peut raise une erreur si check_constraint pas bon.(date supérieur)
-- test des valeur voir le to_date.
call ins_vacation(1,3,TO_DATE('12/09/2015 09:02:44', 'dd/mm/yyyy hh24:mi:ss'),TO_DATE('12/09/2015 09:32:44', 'dd/mm/yyyy hh24:mi:ss'));
call ins_vacation(null,3,TO_DATE('12/09/2015 09:02:44', 'dd/mm/yyyy hh24:mi:ss'),TO_DATE('12/09/2015 09:32:44', 'dd/mm/yyyy hh24:mi:ss'));
call ins_vacation(2,null,TO_DATE('12/09/2015 09:02:44', 'dd/mm/yyyy hh24:mi:ss'),TO_DATE('12/09/2015 09:32:44', 'dd/mm/yyyy hh24:mi:ss'));
call ins_vacation(2,3,null,TO_DATE('12/09/2015 09:32:44', 'dd/mm/yyyy hh24:mi:ss'));
call ins_vacation(2,3,TO_DATE('12/09/2015 09:02:44', 'dd/mm/yyyy hh24:mi:ss'),null);
call ins_vacation(2,3,TO_DATE('12/09/2015 09:02:44', 'dd/mm/yyyy hh24:mi:ss'),TO_DATE('12/09/2015 08:32:44', 'dd/mm/yyyy hh24:mi:ss'));


--#Procédure pour l'insertion d'une ligne dans la table theme.

create or replace procedure modif_vacation( pIdAtelier IN vacation.idatelier%type, pNumero IN vacation.numero%type, pHeureDebut IN VACATION.HEUREDEBUT%TYPE, pHeureFin IN VACATION.HEUREFIN%type)
IS
dup_val_on_index exception;
exnull exception;
PRAGMA EXCEPTION_INIT ( exnull, -1400 ) ;

BEGIN
update vacation
set heuredebut = pHeureDebut, heurefin = pHeureFin
where idatelier=pIdAtelier and numero=pNumero;

EXCEPTION
  when exnull then
    raise_application_error(-20099, 'Affectation null à un champs not null');
    
 when dup_val_on_index then
    raise_application_error(-20009, 'Duplication de clé primaire');
    
  when others then
    raise_application_error(-20001, 'Erreur');
END;
/

--test des update voir to date
call modif_vacation(3,9,TO_DATE('20/09/2015 09:32:44', 'dd/mm/yyyy hh24:mi:ss'),TO_DATE('22/09/2015 09:32:44', 'dd/mm/yyyy hh24:mi:ss'));