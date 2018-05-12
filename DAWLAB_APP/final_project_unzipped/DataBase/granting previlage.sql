-- diferenctiat prevelage 
create user Wudist identified by 'password';
create user WudistA identified by 'password';

create user Mabel identified by 'password' ;

-- granting previlage 

grant select, insert, delete, update
on moviestream.*
to WudistA;

grant all on moviestream .*
 to Wudist;
 
show grants for WudistA; 
show grants for Wudist; 

show grants for Mabel;

select * from mysql.user;