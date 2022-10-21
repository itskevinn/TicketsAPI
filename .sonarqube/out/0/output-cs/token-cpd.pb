ç

OC:\Users\WINDOWS\RiderProjects\TicketsAPI\Domain\Entity\Base\AuditableEntity.cs
	namespace 	
Domain
 
. 
Entity 
. 
Base 
; 
public 
class 
AuditableEntity 
< 
TKey !
>! "
:# $

BaseEntity% /
</ 0
TKey0 4
>4 5
,5 6
IAuditableEntity7 G
{ 
public 

string 
	CreatedBy 
{ 
get !
;! "
set# &
;& '
}( )
=* +
default, 3
!3 4
;4 5
public 

DateTime 
	CreatedOn 
{ 
get  #
;# $
set% (
;( )
}* +
=, -
default. 5
!5 6
;6 7
public 

string 
LastModifiedBy  
{! "
get# &
;& '
set( +
;+ ,
}- .
=/ 0
default1 8
!8 9
;9 :
public 

DateTime 
LastModifiedOn "
{# $
get% (
;( )
set* -
;- .
}/ 0
=1 2
default3 :
!: ;
;; <
}		 ¦
JC:\Users\WINDOWS\RiderProjects\TicketsAPI\Domain\Entity\Base\BaseEntity.cs
	namespace 	
Domain
 
. 
Entity 
. 
Base 
; 
public 
class 

BaseEntity 
< 
TKey 
> 
: 
DomainEntity! -
,- .
IBaseEntity/ :
<: ;
TKey; ?
>? @
{ 
public 

TKey 
Id 
{ 
get 
; 
set 
; 
}  
=! "
default# *
!* +
;+ ,
} £
LC:\Users\WINDOWS\RiderProjects\TicketsAPI\Domain\Entity\Base\DomainEntity.cs
	namespace 	
Domain
 
. 
Entity 
. 
Base 
; 
public 
class 
DomainEntity 
{ 
} ±
PC:\Users\WINDOWS\RiderProjects\TicketsAPI\Domain\Entity\Base\IAuditableEntity.cs
	namespace 	
Domain
 
. 
Entity 
. 
Base 
; 
public 
	interface 
IAuditableEntity !
{ 
public 

string 
	CreatedBy 
{ 
get !
;! "
set# &
;& '
}( )
public 

DateTime 
	CreatedOn 
{ 
get  #
;# $
set% (
;( )
}* +
public 

string 
LastModifiedBy  
{! "
get# &
;& '
set( +
;+ ,
}- .
public		 

DateTime		 
LastModifiedOn		 "
{		# $
get		% (
;		( )
set		* -
;		- .
}		/ 0
}

 é
KC:\Users\WINDOWS\RiderProjects\TicketsAPI\Domain\Entity\Base\IBaseEntity.cs
	namespace 	
Domain
 
. 
Entity 
. 
Base 
; 
public 
	interface 
IBaseEntity 
< 
TKey !
>! "
{ 
public 

TKey 
Id 
{ 
get 
; 
set 
; 
}  
} Ù
CC:\Users\WINDOWS\RiderProjects\TicketsAPI\Domain\Entity\MenuItem.cs
	namespace 	
Domain
 
. 
Entity 
; 
public 
class 
MenuItem 
: 

BaseEntity "
<" #
Guid# '
>' (
{ 
public 
string 
Icon 
{ 
get 
; 
set 
; 
}  !
=" #
default$ +
!+ ,
;, -
public 
string 

RouterLink 
{ 
get 
;  
set! $
;$ %
}& '
=( )
default* 1
!1 2
;2 3
public		 
string		 
Label		 
{		 
get		 
;		 
set		 
;		  
}		! "
=		# $
default		% ,
!		, -
;		- .
public

 
int

 
Order

 
{

 
get

 
;

 
set

 
;

 
}

 
=

  !
default

" )
!

) *
;

* +
public 
IEnumerable 
< 
MenuItemRole  
>  !
MenuItemRoles" /
{0 1
get2 5
;5 6
set7 :
;: ;
}< =
=> ?
default@ G
!G H
;H I
} À
GC:\Users\WINDOWS\RiderProjects\TicketsAPI\Domain\Entity\MenuItemRole.cs
	namespace 	
Domain
 
. 
Entity 
; 
public 
class 
MenuItemRole 
: 

BaseEntity &
<& '
Guid' +
>+ ,
{ 
public 

Guid 

MenuItemId 
{ 
get  
;  !
set" %
;% &
}' (
public		 

MenuItem		 
MenuItem		 
{		 
get		 "
;		" #
set		$ '
;		' (
}		) *
=		+ ,
default		- 4
!		4 5
;		5 6
public

 

Guid

 
RoleId

 
{

 
get

 
;

 
set

 !
;

! "
}

# $
public 

Role 
Role 
{ 
get 
; 
set 
;  
}! "
=# $
default% ,
!, -
;- .
} ß
?C:\Users\WINDOWS\RiderProjects\TicketsAPI\Domain\Entity\Role.cs
	namespace 	
Domain
 
. 
Entity 
; 
public 
class 
Role 
: 

BaseEntity 
< 
Guid #
># $
{ 
public		 

string		 
RoleName		 
{		 
get		  
;		  !
set		" %
;		% &
}		' (
=		) *
default		+ 2
!		2 3
;		3 4
[

 
	NotMapped

 
]

 
[

 

JsonIgnore

 
]

 
public

 #
IEnumerable

$ /
<

/ 0
MenuItem

0 8
>

8 9
Authorities

: E
{

F G
get

H K
;

K L
set

M P
;

P Q
}

R S
=

T U
default

V ]
!

] ^
;

^ _
public 

IEnumerable 
< 
UserRole 
>  
	UserRoles! *
{+ ,
get- 0
;0 1
set2 5
;5 6
}7 8
=9 :
default; B
!B C
;C D
public 

IEnumerable 
< 
MenuItemRole #
># $
RoleMenuItems% 2
{3 4
get5 8
;8 9
set: =
;= >
}? @
=A B
defaultC J
!J K
;K L
} à
AC:\Users\WINDOWS\RiderProjects\TicketsAPI\Domain\Entity\Ticket.cs
	namespace 	
Domain
 
. 
Entity 
; 
public 
class 
Ticket 
: 
AuditableEntity %
<% &
Guid& *
>* +
{ 
public 

string 
Code 
{ 
get 
; 
set !
;! "
}# $
=% &
default' .
!. /
;/ 0
public 

string 
Title 
{ 
get 
; 
set "
;" #
}$ %
=& '
default( /
!/ 0
;0 1
public		 

string		 
Message		 
{		 
get		 
;		  
set		! $
;		$ %
}		& '
=		( )
default		* 1
!		1 2
;		2 3
public

 

string

 
Status

 
{

 
get

 
;

 
set

  #
;

# $
}

% &
=

' (
default

) 0
!

0 1
;

1 2
public 

User 
GeneratedBy 
{ 
get !
;! "
set# &
;& '
}( )
=* +
default, 3
!3 4
;4 5
public 

DateTime 
GeneratedOn 
{  !
get" %
;% &
set' *
;* +
}, -
public 

DateTime 
SolvedOn 
{ 
get "
;" #
set$ '
;' (
}) *
public 

DateTime 
AllegedSolveDate $
{% &
get' *
;* +
set, /
;/ 0
}1 2
public 

string 
Description 
{ 
get  #
;# $
set% (
;( )
}* +
=, -
default. 5
!5 6
;6 7
} Ë
GC:\Users\WINDOWS\RiderProjects\TicketsAPI\Domain\Entity\TicketDetail.cs
	namespace 	
Domain
 
. 
Entity 
; 
public 
class 
TicketDetail 
: 
AuditableEntity +
<+ ,
Guid, 0
>0 1
{ 
public 

string 
Message 
{ 
get 
;  
set! $
;$ %
}& '
=( )
default* 1
!1 2
;2 3
public		 

List		 
<		 
string		 
>		 
AttachmentsUrls		 '
{		( )
get		* -
;		- .
set		/ 2
;		2 3
}		4 5
=		6 7
default		8 ?
!		? @
;		@ A
}

 í
?C:\Users\WINDOWS\RiderProjects\TicketsAPI\Domain\Entity\User.cs
	namespace 	
Domain
 
. 
Entity 
; 
public 
class 
User 
: 

BaseEntity 
< 
Guid #
># $
{ 
public		 

string		 
Name		 
{		 
get		 
;		 
set		 !
;		! "
}		# $
=		% &
default		' .
!		. /
;		/ 0
public

 

string

 
Username

 
{

 
get

  
;

  !
set

" %
;

% &
}

' (
=

) *
default

+ 2
!

2 3
;

3 4
public 

string 
Password 
{ 
get  
;  !
set" %
;% &
}' (
=) *
default+ 2
!2 3
;3 4
public 

IEnumerable 
< 
UserRole 
>  
	UserRoles! *
{+ ,
get- 0
;0 1
set2 5
;5 6
}7 8
=9 :
default; B
!B C
;C D
[ 
	NotMapped 
] 
[ 

JsonIgnore 
] 
public #
IEnumerable$ /
</ 0
Role0 4
>4 5
Roles6 ;
{< =
get> A
;A B
setC F
;F G
}H I
=J K
defaultL S
!S T
;T U
} ù

CC:\Users\WINDOWS\RiderProjects\TicketsAPI\Domain\Entity\UserRole.cs
	namespace 	
Domain
 
. 
Entity 
; 
public 
class 
UserRole 
: 

BaseEntity "
<" #
Guid# '
>' (
{ 
public 

UserRole 
( 
Guid 
userId 
,  
Guid! %
roleId& ,
), -
{		 
UserId

 
=

 
userId

 
;

 
RoleId 
= 
roleId 
; 
} 
public 

Guid 
UserId 
{ 
get 
; 
set !
;! "
}# $
public 

User 
User 
{ 
get 
; 
set 
;  
}! "
=# $
default% ,
!, -
;- .
public 

Guid 
RoleId 
{ 
get 
; 
set !
;! "
}# $
public 

Role 
Role 
{ 
get 
; 
set 
;  
}! "
=# $
default% ,
!, -
;- .
} “

KC:\Users\WINDOWS\RiderProjects\TicketsAPI\Domain\Exceptions\AppException.cs
	namespace 	
Domain
 
. 

Exceptions 
; 
public 
class 
AppException 
: 
	Exception %
{ 
public 

AppException 
( 
) 
{ 
}		 
public 

AppException 
( 
string 
message &
)& '
:( )
base* .
(. /
message/ 6
)6 7
{ 
} 
public 

AppException 
( 
string 
message &
,& '
	Exception( 1
inner2 7
)7 8
:9 :
base; ?
(? @
message@ G
,G H
innerI N
)N O
{ 
} 
	protected 
AppException 
( 
SerializationInfo 
info 
, 
StreamingContext 
context  
)  !
:" #
base$ (
(( )
info) -
,- .
context/ 6
)6 7
{ 
} 
} ©
LC:\Users\WINDOWS\RiderProjects\TicketsAPI\Domain\Ports\IGenericRepository.cs
	namespace 	
Domain
 
. 
Ports 
; 
public 
	interface 
IGenericRepository #
<# $
TEntity$ +
>+ ,
where- 2
TEntity3 :
:; <
DomainEntity= I
{ 
Task 
< 	
TEntity	 
> 
CreateAsync 
( 
TEntity %
entity& ,
), -
;- .
void		 
Update			 
(		 
TEntity		 
entity		 
)		 
;		  
Task

 
DeleteAsync

	 
(

 
object

 
entity

 "
)

" #
;

# $
void 
Delete	 
( 
TEntity 
entity 
) 
;  
Task 
< 	
TEntity	 
? 
> 
	FindAsync 
( 
object #
?# $
id% '
)' (
;( )
Task 
< 	
bool	 
> 
ExistsAsync 
( 
object !
id" $
)$ %
;% &
Task 
CreateAllAsync	 
( 
IEnumerable #
<# $
TEntity$ +
>+ ,
entities- 5
)5 6
;6 7
Task 
< 	
TEntity	 
> 
Find 
( 

Expression !
<! "
Func" &
<& '
TEntity' .
,. /
bool0 4
>4 5
>5 6
?6 7
filter8 >
=? @
nullA E
,E F
bool 

isTracking 
= 
false 
,  
string #
includeStringProperties &
=' (
$str) +
)+ ,
;, -
Task 
< 	

IQueryable	 
< 
TEntity 
> 
> 
GetAsync &
(& '

Expression 
< 
Func 
< 
TEntity 
,  
bool! %
>% &
>& '
?' (
filter) /
=0 1
null2 6
,6 7
Func 
< 

IQueryable 
< 
TEntity 
>  
,  !
IOrderedQueryable" 3
<3 4
TEntity4 ;
>; <
>< =
?= >
orderBy? F
=G H
nullI M
,M N
bool 

isTracking 
= 
false 
,  
string #
includeStringProperties &
=' (
$str) +
)+ ,
;, -
} ð
MC:\Users\WINDOWS\RiderProjects\TicketsAPI\Domain\Ports\IMenuItemRepository.cs
	namespace 	
Domain
 
. 
Ports 
; 
public 
	interface 
IMenuItemRepository $
:% &
IGenericRepository' 9
<9 :
MenuItem: B
>B C
{ 
} ü
QC:\Users\WINDOWS\RiderProjects\TicketsAPI\Domain\Ports\IMenuItemRoleRepository.cs
	namespace 	
Domain
 
. 
Ports 
; 
public 
	interface #
IMenuItemRoleRepository (
:) *
IGenericRepository+ =
<= >
MenuItemRole> J
>J K
{ 
} ä
IC:\Users\WINDOWS\RiderProjects\TicketsAPI\Domain\Ports\IRoleRepository.cs
	namespace 	
Domain
 
. 
Ports 
; 
public 
	interface 
IRoleRepository  
:! "
IGenericRepository# 5
<5 6
Role6 :
>: ;
{ 
} Ë
QC:\Users\WINDOWS\RiderProjects\TicketsAPI\Domain\Ports\ITicketDetailRepository.cs
	namespace 	
Domain
 
. 
Ports 
; 
public 
	interface #
ITicketDetailRepository (
:) *
IGenericRepository+ =
<= >
TicketDetail> J
>J K
{ 
Task 
< 	
IEnumerable	 
< 
TicketDetail !
>! "
>" #*
GetTicketDetailByTicketIdAsync$ B
(B C
GuidC G
ticketIdH P
,P Q
CancellationTokenR c
cancellationTokend u
)u v
;v w
} ž
KC:\Users\WINDOWS\RiderProjects\TicketsAPI\Domain\Ports\ITicketRepository.cs
	namespace 	
Domain
 
. 
Ports 
; 
public 
	interface 
ITicketRepository "
:# $
IGenericRepository% 7
<7 8
Ticket8 >
>> ?
{ 
Task 
< 	
Ticket	 
> 
FindByCodeAsync  
(  !
string! '
code( ,
), -
;- .
} ä
IC:\Users\WINDOWS\RiderProjects\TicketsAPI\Domain\Ports\IUserRepository.cs
	namespace 	
Domain
 
. 
Ports 
; 
public 
	interface 
IUserRepository  
:  !
IGenericRepository" 4
<4 5
User5 9
>9 :
{ 
} ð
MC:\Users\WINDOWS\RiderProjects\TicketsAPI\Domain\Ports\IUserRoleRepository.cs
	namespace 	
Domain
 
. 
Ports 
; 
public 
	interface 
IUserRoleRepository $
:% &
IGenericRepository' 9
<9 :
UserRole: B
>B C
{ 
} 