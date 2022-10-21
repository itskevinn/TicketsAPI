è
TC:\Users\WINDOWS\RiderProjects\TicketsAPI\Infrastructure\Core\Helpers\AppSettings.cs
	namespace 	
Infrastructure
 
. 
Core 
. 
Helpers %
;% &
public 
class 
AppSettings 
{ 
public 

string 
Secret 
{ 
get 
; 
set  #
;# $
}% &
=' (
default) 0
!0 1
;1 2
} ¡
YC:\Users\WINDOWS\RiderProjects\TicketsAPI\Infrastructure\Core\Interface\IScopedService.cs
	namespace 	
Infrastructure
 
. 
Core 
. 
	Interface '
;' (
public 
	interface 
IScopedService 
{ 
} «
\C:\Users\WINDOWS\RiderProjects\TicketsAPI\Infrastructure\Core\Interface\ITransientService.cs
	namespace 	
Infrastructure
 
. 
Core 
. 
	Interface '
;' (
public 
	interface 
ITransientService "
{ 
} Ê
RC:\Users\WINDOWS\RiderProjects\TicketsAPI\Infrastructure\Core\Response\Response.cs
	namespace 	
Infrastructure
 
. 
Core 
. 
Response &
;& '
public 
class 
Response 
< 
T 
> 
{ 
public 

Response 
( 
HttpStatusCode "

statusCode# -
,- .
string/ 5
message6 =
,= >
bool? C
successD K
,K L
TM N
dataO S
=T U
defaultV ]
!] ^
,^ _
	Exception 
	exception 
= 
null "
!" #
)# $
{		 

StatusCode

 
=

 

statusCode

 
;

  
Message 
= 
message 
; 
Success 
= 
success 
; 
Data 
= 
data 
; 
	Exception 
= 
	exception 
; 
ExceptionMessage 
= 
	exception $
?$ %
.% &
Message& -
;- .
} 
public 

HttpStatusCode 

StatusCode $
{% &
get' *
;* +
set, /
;/ 0
}1 2
public 

string 
Message 
{ 
get 
;  
set! $
;$ %
}& '
public 

bool 
Success 
{ 
get 
; 
set "
;" #
}$ %
public 

T 
Data 
{ 
get 
; 
set 
; 
} 
public 

string 
? 
ExceptionMessage #
{$ %
get& )
;) *
set+ .
;. /
}0 1
public 

	Exception 
	Exception 
{  
get! $
;$ %
set& )
;) *
}+ ,
} ç
OC:\Users\WINDOWS\RiderProjects\TicketsAPI\Infrastructure\Core\Utils\Response.cs
	namespace 	
Infrastructure
 
. 
Core 
. 
Utils #
{ 
public 

class 
Response 
{ 
public 
Response 
( 
bool 
success $
)$ %
{ 	
Success 
= 
success 
; 
} 	
public

 
Response

 
(

 
bool

 
success

 $
,

$ %
string

& ,
?

, -
error

. 3
)

3 4
: 
this 
( 
success 
) 
{ 	
Error 
= 
error 
; 
} 	
public 
bool 
Success 
{ 
get !
;! "
private# *
set+ .
;. /
}0 1
public 
string 
? 
Error 
{ 
get "
;" #
private$ +
set, /
;/ 0
}1 2
public 
static 
implicit 
operator '
bool( ,
(, -
Response- 5
response6 >
)> ?
{ 	
return 
response 
. 
Success #
;# $
} 	
} 
public 

class 
FailResponse 
: 
Response  (
{ 
public 
FailResponse 
( 
) 
: 
base 
( 
false 
) 
{ 	
} 	
public!! 
FailResponse!! 
(!! 
string!! "
?!!" #
error!!$ )
)!!) *
:"" 
base"" 
("" 
false"" 
,"" 
error"" 
)""  
{## 	
}$$ 	
}%% 
public'' 

class'' 
SuccessResponse''  
:''! "
Response''# +
{(( 
public)) 
SuccessResponse)) 
()) 
)))  
:** 
base** 
(** 
true** 
)** 
{++ 	
},, 	
public.. 
static.. 
DataResponse.. "
<.." #
T..# $
>..$ %
WithData..& .
<... /
T../ 0
>..0 1
(..1 2
T..2 3
data..4 8
)..8 9
{// 	
return00 
new00 
DataResponse00 #
<00# $
T00$ %
>00% &
(00& '
data00' +
)00+ ,
;00, -
}11 	
}22 
public44 

class44 
DataResponse44 
<44 
T44 
>44  
:44! "
SuccessResponse44# 2
{55 
public66 
DataResponse66 
(66 
T66 
obj66 !
)66! "
{77 	
Data88 
=88 
obj88 
;88 
}99 	
public;; 
T;; 
Data;; 
{;; 
get;; 
;;; 
private;; $
set;;% (
;;;( )
};;* +
}<< 
}== ÓH
^C:\Users\WINDOWS\RiderProjects\TicketsAPI\Infrastructure\Persistence\Base\GenericRepository.cs
	namespace 	
Infrastructure
 
. 
Persistence $
.$ %
Base% )
;) *
public		 
class		 
GenericRepository		 
<		 
TEntity		 &
>		& '
:		( )
IGenericRepository		* <
<		< =
TEntity		= D
>		D E
where		F K
TEntity		L S
:		T U
DomainEntity		V b
{

 
	protected 
readonly 
TicketsContext %
Context& -
;- .
private 
readonly 
DbSet 
< 
TEntity "
>" #
_dbSet$ *
;* +
public 

GenericRepository 
( 
TicketsContext +
context, 3
)3 4
{ 
Context 
= 
context 
; 
_dbSet 
= 
context 
. 
Set 
< 
TEntity $
>$ %
(% &
)& '
;' (
} 
public 

virtual 
async 
Task 
< 
TEntity %
>% &
CreateAsync' 2
(2 3
TEntity3 :
entity; A
)A B
{ 
await 
_dbSet 
. 
AddAsync 
( 
entity $
)$ %
;% &
return 
entity 
; 
} 
public 

virtual 
void 
Update 
( 
TEntity &
entityToUpdate' 5
)5 6
{ 
_dbSet 
. 
Attach 
( 
entityToUpdate $
)$ %
;% &
Context 
. 
Entry 
( 
entityToUpdate $
)$ %
.% &
State& +
=, -
EntityState. 9
.9 :
Modified: B
;B C
} 
public   

virtual   
async   
Task   
DeleteAsync   )
(  ) *
object  * 0
id  1 3
)  3 4
{!! 
var"" 
entityToDelete"" 
="" 
await"" "
_dbSet""# )
."") *
	FindAsync""* 3
(""3 4
id""4 6
)""6 7
;""7 8
if## 

(## 
entityToDelete## 
!=## 
null## "
)##" #
Delete##$ *
(##* +
entityToDelete##+ 9
)##9 :
;##: ;
}$$ 
public&& 

virtual&& 
void&& 
Delete&& 
(&& 
TEntity&& &
entityToDelete&&' 5
)&&5 6
{'' 
if(( 

((( 
Context(( 
.(( 
Entry(( 
((( 
entityToDelete(( (
)((( )
.(() *
State((* /
==((0 2
EntityState((3 >
.((> ?
Detached((? G
)((G H
{)) 	
_dbSet** 
.** 
Attach** 
(** 
entityToDelete** (
)**( )
;**) *
}++ 	
_dbSet-- 
.-- 
Remove-- 
(-- 
entityToDelete-- $
)--$ %
;--% &
}.. 
public00 

virtual00 
async00 
Task00 
<00 
TEntity00 %
?00% &
>00& '
	FindAsync00( 1
(001 2
object002 8
?008 9
id00: <
)00< =
{11 
return22 
await22 
_dbSet22 
.22 
	FindAsync22 %
(22% &
id22& (
)22( )
;22) *
}33 
public55 

virtual55 
async55 
Task55 
<55 
bool55 "
>55" #
ExistsAsync55$ /
(55/ 0
object550 6
id557 9
)559 :
{66 
return77 
await77 
_dbSet77 
.77 
	FindAsync77 %
(77% &
id77& (
)77( )
!=77* ,
null77- 1
;771 2
}88 
public:: 

virtual:: 
async:: 
Task:: 
CreateAllAsync:: ,
(::, -
IEnumerable::- 8
<::8 9
TEntity::9 @
>::@ A
entities::B J
)::J K
{;; 
await<< 
_dbSet<< 
.<< 
AddRangeAsync<< "
(<<" #
entities<<# +
)<<+ ,
;<<, -
}== 
public?? 

virtual?? 
Task?? 
<?? 
TEntity?? 
>??  
Find??! %
(??% &

Expression??& 0
<??0 1
Func??1 5
<??5 6
TEntity??6 =
,??= >
bool??? C
>??C D
>??D E
???E F
filter??G M
=??N O
null??P T
,??T U
bool??V Z

isTracking??[ e
=??f g
false??h m
,??m n
string@@ #
includeStringProperties@@ &
=@@' (
$str@@) +
)@@+ ,
{AA 

IQueryableBB 
<BB 
TEntityBB 
>BB 
queryBB !
=BB" #
_dbSetBB$ *
;BB* +
ifDD 

(DD 
filterDD 
!=DD 
nullDD 
)DD 
{EE 	
queryFF 
=FF 
queryFF 
.FF 
WhereFF 
(FF  
filterFF  &
)FF& '
;FF' (
}GG 	
queryII 
=II #
includeStringPropertiesII '
.II' (
SplitII( -
(II- .
newII. 1
[II1 2
]II2 3
{II4 5
$charII6 9
}II: ;
,II; <
StringSplitOptionsII= O
.IIO P
RemoveEmptyEntriesIIP b
)IIb c
.JJ 
	AggregateJJ 
(JJ 
queryJJ 
,JJ 
(JJ 
currentJJ &
,JJ& '
includePropertyJJ( 7
)JJ7 8
=>JJ9 ;
currentJJ< C
.JJC D
IncludeJJD K
(JJK L
includePropertyJJL [
)JJ[ \
)JJ\ ]
;JJ] ^
returnLL 
TaskLL 
.LL 

FromResultLL 
(LL 
(LL  
queryLL  %
.LL% &
FirstOrDefaultLL& 4
(LL4 5
)LL5 6
??LL7 9
nullLL: >
)LL> ?
??LL@ B
throwLLC H
newLLI L"
NullReferenceExceptionLLM c
(LLc d
)LLd e
)LLe f
;LLf g
}MM 
publicOO 

virtualOO 
TaskOO 
<OO 

IQueryableOO "
<OO" #
TEntityOO# *
>OO* +
>OO+ ,
GetAsyncOO- 5
(OO5 6

ExpressionOO6 @
<OO@ A
FuncOOA E
<OOE F
TEntityOOF M
,OOM N
boolOOO S
>OOS T
>OOT U
?OOU V
filterOOW ]
=OO^ _
nullOO` d
,OOd e
FuncPP 
<PP 

IQueryablePP 
<PP 
TEntityPP 
>PP  
,PP  !
IOrderedQueryablePP" 3
<PP3 4
TEntityPP4 ;
>PP; <
>PP< =
?PP= >
orderByPP? F
=PPG H
nullPPI M
,PPM N
boolPPO S

isTrackingPPT ^
=PP_ `
falsePPa f
,PPf g
stringQQ #
includeStringPropertiesQQ &
=QQ' (
$strQQ) +
)QQ+ ,
{RR 

IQueryableSS 
<SS 
TEntitySS 
>SS 
querySS !
=SS" #
_dbSetSS$ *
;SS* +
ifUU 

(UU 
filterUU 
!=UU 
nullUU 
)UU 
{VV 	
queryWW 
=WW 
queryWW 
.WW 
WhereWW 
(WW  
filterWW  &
)WW& '
;WW' (
}XX 	
queryZZ 
=ZZ #
includeStringPropertiesZZ '
.ZZ' (
SplitZZ( -
(ZZ- .
newZZ. 1
[ZZ1 2
]ZZ2 3
{ZZ4 5
$charZZ6 9
}ZZ: ;
,ZZ; <
StringSplitOptionsZZ= O
.ZZO P
RemoveEmptyEntriesZZP b
)ZZb c
.[[ 
	Aggregate[[ 
([[ 
query[[ 
,[[ 
([[ 
current[[ &
,[[& '
includeProperty[[( 7
)[[7 8
=>[[9 ;
current[[< C
.[[C D
Include[[D K
([[K L
includeProperty[[L [
)[[[ \
)[[\ ]
;[[] ^
return]] 
Task]] 
.]] 

FromResult]] 
(]] 
orderBy]] &
!=]]' )
null]]* .
?]]/ 0
orderBy]]1 8
(]]8 9
query]]9 >
)]]> ?
:]]@ A
query]]B G
)]]G H
;]]H I
}^^ 
}__ å	
^C:\Users\WINDOWS\RiderProjects\TicketsAPI\Infrastructure\Persistence\Context\TicketsContext.cs
	namespace 	
Infrastructure
 
. 
Persistence $
.$ %
Context% ,
;, -
public 
class 
TicketsContext 
: 
	DbContext '
{ 
public		 

DbSet		 
<		 
User		 
>		 
Users		 
{		 
get		 "
;		" #
set		$ '
;		' (
}		) *
=		+ ,
default		- 4
!		4 5
;		5 6
	protected

 
override

 
void

 
OnModelCreating

 +
(

+ ,
ModelBuilder

, 8
modelBuilder

9 E
)

E F
{ 
base 
. 
OnModelCreating 
( 
modelBuilder )
)) *
;* +
modelBuilder 
. 
ApplyConfiguration '
(' (
new( +
UserConfiguration, =
(= >
)> ?
)? @
;@ A
} 
} ˛
aC:\Users\WINDOWS\RiderProjects\TicketsAPI\Infrastructure\Persistence\Factory\ConnectionFactory.cs
	namespace 	
Infrastructure
 
. 
Persistence $
.$ %
Factory% ,
;, -
public 
class 
ConnectionFactory 
:  
IConnectionFactory! 3
{ 
private		 
readonly		 
string		 
?		 
_connectionString		 .
;		. /
public 

ConnectionFactory 
( 
IConfiguration +
configuration, 9
)9 :
{ 
_connectionString 
= 
configuration )
.) *
GetConnectionString* =
(= >
$str> Q
)Q R
;R S
} 
public 

IDbConnection 
? 

Connection $
{ 
get 
{ 	
var 
factory 
= 
DbProviderFactories -
.- .

GetFactory. 8
(8 9
$str9 P
)P Q
;Q R
var 
conn 
= 
factory 
. 
CreateConnection /
(/ 0
)0 1
;1 2
if 
( 
conn 
== 
null 
) 
return $
null% )
;) *
conn 
. 
ConnectionString !
=" #
_connectionString$ 5
;5 6
conn 
. 
Open 
( 
) 
; 
return 
conn 
; 
} 	
} 
} Á
bC:\Users\WINDOWS\RiderProjects\TicketsAPI\Infrastructure\Persistence\Factory\IConnectionFactory.cs
	namespace 	
Infrastructure
 
. 
Persistence $
.$ %
Factory% ,
;, -
public 
	interface 
IConnectionFactory #
{ 
public 

IDbConnection 
? 

Connection $
{% &
get' *
;* +
}, -
} „

aC:\Users\WINDOWS\RiderProjects\TicketsAPI\Infrastructure\Persistence\Mapping\UserConfiguration.cs
	namespace 	
Infrastructure
 
. 
Persistence $
.$ %
Mapping% ,
;, -
public 
class 
UserConfiguration 
:  $
IEntityTypeConfiguration! 9
<9 :
User: >
>> ?
{ 
public		 

void		 
	Configure		 
(		 
EntityTypeBuilder		 +
<		+ ,
User		, 0
>		0 1
builder		2 9
)		9 :
{

 
builder 
. 
HasKey 
( 
p 
=> 
p 
. 
Id  
)  !
;! "
builder 
. 
Property 
( 
p 
=> 
p 
.  
Name  $
)$ %
.% &
HasMaxLength& 2
(2 3
$num3 5
)5 6
;6 7
builder 
. 
Property 
( 
p 
=> 
p 
.  
Username  (
)( )
.) *
HasMaxLength* 6
(6 7
$num7 9
)9 :
;: ;
} 
} ‡
gC:\Users\WINDOWS\RiderProjects\TicketsAPI\Infrastructure\Persistence\Repositories\MenuItemRepository.cs
	namespace 	
Infrastructure
 
. 
Persistence $
.$ %
Repositories% 1
;1 2
public 
class 
MenuItemRepository 
:  !
GenericRepository" 3
<3 4
MenuItem4 <
>< =
,= >
IMenuItemRepository? R
{		 
public

 

MenuItemRepository

 
(

 
TicketsContext

 ,
context

- 4
)

4 5
:

6 7
base

8 <
(

< =
context

= D
)

D E
{ 
} 
} Ù
kC:\Users\WINDOWS\RiderProjects\TicketsAPI\Infrastructure\Persistence\Repositories\MenuItemRoleRepository.cs
	namespace 	
Infrastructure
 
. 
Persistence $
.$ %
Repositories% 1
;1 2
public 
class "
MenuItemRoleRepository #
:$ %
GenericRepository& 7
<7 8
MenuItemRole8 D
>D E
,E F#
IMenuItemRoleRepositoryG ^
{		 
public

 
"
MenuItemRoleRepository

 !
(

! "
TicketsContext

" 0
context

1 8
)

8 9
:

: ;
base

< @
(

@ A
context

A H
)

H I
{ 
} 
} Ã
cC:\Users\WINDOWS\RiderProjects\TicketsAPI\Infrastructure\Persistence\Repositories\RoleRepository.cs
	namespace 	
Infrastructure
 
. 
Persistence $
.$ %
Repositories% 1
;1 2
public 
class 
RoleRepository 
: 
GenericRepository .
<. /
Role/ 3
>3 4
,4 5
IRoleRepository6 E
{		 
public

 

RoleRepository

 
(

 
TicketsContext

 (
context

) 0
)

0 1
:

2 3
base

4 8
(

8 9
context

9 @
)

@ A
{ 
} 
} ˆ
kC:\Users\WINDOWS\RiderProjects\TicketsAPI\Infrastructure\Persistence\Repositories\TicketDetailRepository.cs
	namespace 	
Infrastructure
 
. 
Persistence $
.$ %
Repositories% 1
;1 2
public

 
class

 "
TicketDetailRepository

 #
:

$ %
GenericRepository

& 7
<

7 8
TicketDetail

8 D
>

D E
,

E F#
ITicketDetailRepository

G ^
{ 
private 
readonly 
IConnectionFactory '
_connectionFactory( :
;: ;
public 
"
TicketDetailRepository !
(! "
TicketsContext" 0
context1 8
,8 9
IConnectionFactory: L
connectionFactoryM ^
)^ _
:` a
baseb f
(f g
contextg n
)n o
{ 
_connectionFactory 
= 
connectionFactory .
;. /
} 
public 

async 
Task 
< 
IEnumerable "
<" #
TicketDetail# /
>/ 0
>0 1*
GetTicketDetailByTicketIdAsync2 P
(P Q
GuidQ U
ticketIdV ^
,^ _
CancellationToken 
cancellationToken +
=, -
default. 5
)5 6
{ 
using 
var 
conn 
= 
_connectionFactory +
.+ ,

Connection, 6
??7 9
throw 
new ""
NullReferenceException# 9
(9 :
nameof: @
(@ A
_connectionFactoryA S
.S T

ConnectionT ^
)^ _
)_ `
;` a
{ 	
var 
sqlQuery 
= 
$" 
$str I
{I J
ticketIdJ R
}R S
"S T
;T U
var 
ticketDetails 
= 
await  %
conn& *
.* +

QueryAsync+ 5
<5 6
TicketDetail6 B
>B C
(C D
sqlQueryD L
)L M
;M N
conn 
. 
Close 
( 
) 
; 
return 
ticketDetails  
.  !
ToList! '
(' (
)( )
;) *
} 	
} 
}   ÿ
eC:\Users\WINDOWS\RiderProjects\TicketsAPI\Infrastructure\Persistence\Repositories\TicketRepository.cs
	namespace 	
Infrastructure
 
. 
Persistence $
.$ %
Repositories% 1
;1 2
public

 
class

 
TicketRepository

 
:

 
GenericRepository

  1
<

1 2
Ticket

2 8
>

8 9
,

9 :
ITicketRepository

; L
{ 
private 
readonly 
IDbConnection "
_dbConnection# 0
;0 1
public 

TicketRepository 
( 
TicketsContext *
context+ 2
,2 3
IDbConnection4 A
dbConnectionB N
)N O
:P Q
baseR V
(V W
contextW ^
)^ _
{ 
_dbConnection 
= 
dbConnection $
;$ %
} 
public 

async 
Task 
< 
Ticket 
> 
FindByCodeAsync -
(- .
string. 4
code5 9
)9 :
{ 
var 
sql 
= 
$" 
$str 7
{7 8
code8 <
}< =
$str= >
"> ?
;? @
return 
await 
_dbConnection "
." #
QueryFirstAsync# 2
<2 3
Ticket3 9
>9 :
(: ;
sql; >
)> ?
;? @
} 
} Ã
cC:\Users\WINDOWS\RiderProjects\TicketsAPI\Infrastructure\Persistence\Repositories\UserRepository.cs
	namespace 	
Infrastructure
 
. 
Persistence $
.$ %
Repositories% 1
;1 2
public 
class 
UserRepository 
: 
GenericRepository /
</ 0
User0 4
>4 5
,5 6
IUserRepository7 F
{		 
public

 

UserRepository

 
(

 
TicketsContext

 (
context

) 0
)

0 1
:

2 3
base

4 8
(

8 9
context

9 @
)

@ A
{ 
} 
} ‡
gC:\Users\WINDOWS\RiderProjects\TicketsAPI\Infrastructure\Persistence\Repositories\UserRoleRepository.cs
	namespace 	
Infrastructure
 
. 
Persistence $
.$ %
Repositories% 1
;1 2
public 
class 
UserRoleRepository 
:  
GenericRepository! 2
<2 3
UserRole3 ;
>; <
,< =
IUserRoleRepository> Q
{		 
public

 

UserRoleRepository

 
(

 
TicketsContext

 ,
context

- 4
)

4 5
:

6 7
base

8 <
(

< =
context

= D
)

D E
{ 
} 
} ¶
^C:\Users\WINDOWS\RiderProjects\TicketsAPI\Infrastructure\Persistence\UnitOfWork\IUnitOfWork.cs
	namespace 	
Infrastructure
 
. 
Persistence $
.$ %

UnitOfWork% /
;/ 0
public 
	interface 
IUnitOfWork 
{ 
public 

TicketRepository 
TicketRepository ,
{- .
get/ 2
;2 3
}4 5
public 
"
TicketDetailRepository !"
TicketDetailRepository" 8
{9 :
get; >
;> ?
}@ A
public		 

UserRepository		 
UserRepository		 (
{		) *
get		+ .
;		. /
}		0 1
public 

UserRoleRepository 
UserRoleRepository 0
{1 2
get3 6
;6 7
}8 9
public 

RoleRepository 
RoleRepository (
{) *
get+ .
;. /
}0 1
public 

MenuItemRepository 
MenuItemRepository 0
{1 2
get3 6
;6 7
}8 9
public 
"
MenuItemRoleRepository !"
MenuItemRoleRepository" 8
{9 :
get; >
;> ?
}@ A
public 

void 
Save 
( 
) 
; 
	protected 
void 
Dispose 
( 
bool 
	disposing  )
)) *
;* +
public 

void 
Dispose 
( 
) 
; 
} ‡.
]C:\Users\WINDOWS\RiderProjects\TicketsAPI\Infrastructure\Persistence\UnitOfWork\UnitOfWork.cs
	namespace 	
Infrastructure
 
. 
Persistence $
.$ %

UnitOfWork% /
;/ 0
public 
class 

UnitOfWork 
: 
IUnitOfWork %
,% &
IDisposable' 2
{ 
private		 
readonly		 
IConnectionFactory		 '
_connectionFactory		( :
;		: ;
public 


UnitOfWork 
( 
IConnectionFactory (
connectionFactory) :
): ;
{ 
_connectionFactory 
= 
connectionFactory .
??/ 1
throw2 7
new8 ;!
ArgumentNullException< Q
(Q R
nameofR X
(X Y
connectionFactoryY j
)j k
)k l
;l m
} 
private 
readonly 
TicketsContext #
_context$ ,
=- .
new/ 2
(2 3
)3 4
;4 5
private 
TicketRepository 
? 
_ticketRepository /
;/ 0
private "
TicketDetailRepository "
?" ##
_ticketDetailRepository$ ;
;; <
private 
UserRepository 
? 
_userRepository +
;+ ,
private 
MenuItemRepository 
? 
_menuItemRepository  3
;3 4
private "
MenuItemRoleRepository "
?" ##
_menuItemRoleRepository$ ;
;; <
private 
UserRoleRepository 
? 
_userRoleRepository  3
;3 4
private 
RoleRepository 
? 
_roleRepository +
;+ ,
public 

TicketRepository 
TicketRepository ,
{ 
get 
{ 
return 
_ticketRepository &
??=' *
new+ .
TicketRepository/ ?
(? @
_context@ H
,H I
_connectionFactoryJ \
.\ ]

Connection] g
)g h
;h i
}j k
} 
public 

UserRoleRepository 
UserRoleRepository 0
{   
get!! 
{!! 
return!! 
_userRoleRepository!! (
??=!!) ,
new!!- 0
UserRoleRepository!!1 C
(!!C D
_context!!D L
)!!L M
;!!M N
}!!O P
}"" 
public$$ 

RoleRepository$$ 
RoleRepository$$ (
{%% 
get&& 
{&& 
return&& 
_roleRepository&& $
??=&&% (
new&&) ,
RoleRepository&&- ;
(&&; <
_context&&< D
)&&D E
;&&E F
}&&G H
}'' 
public)) 
"
TicketDetailRepository)) !"
TicketDetailRepository))" 8
{** 
get++ 
{++ 
return++ #
_ticketDetailRepository++ ,
??=++- 0
new++1 4"
TicketDetailRepository++5 K
(++K L
_context++L T
,++T U
_connectionFactory++V h
)++h i
;++i j
}++k l
},, 
public.. 

MenuItemRepository.. 
MenuItemRepository.. 0
{// 
get00 
{00 
return00 
_menuItemRepository00 (
??=00) ,
new00- 0
MenuItemRepository001 C
(00C D
_context00D L
)00L M
;00M N
}00O P
}11 
public33 
"
MenuItemRoleRepository33 !"
MenuItemRoleRepository33" 8
{44 
get55 
{55 
return55 #
_menuItemRoleRepository55 ,
??=55- 0
new551 4"
MenuItemRoleRepository555 K
(55K L
_context55L T
)55T U
;55U V
}55W X
}66 
public88 

UserRepository88 
UserRepository88 (
{99 
get:: 
{:: 
return:: 
_userRepository:: $
??=::% (
new::) ,
UserRepository::- ;
(::; <
_context::< D
)::D E
;::E F
}::G H
};; 
public== 

void== 
Save== 
(== 
)== 
{>> 
_context?? 
.?? 
SaveChanges?? 
(?? 
)?? 
;?? 
}@@ 
voidBB 
IUnitOfWorkBB	 
.BB 
DisposeBB 
(BB 
boolBB !
	disposingBB" +
)BB+ ,
{CC 
DisposeDD 
(DD 
	disposingDD 
)DD 
;DD 
}EE 
privateGG 
boolGG 
	_disposedGG 
;GG 
	protectedII 
virtualII 
voidII 
DisposeII "
(II" #
boolII# '
	disposingII( 1
)II1 2
{JJ 
ifKK 

(KK 
!KK 
	_disposedKK 
)KK 
{LL 	
ifMM 
(MM 
	disposingMM 
)MM 
{NN 
_contextOO 
.OO 
DisposeOO  
(OO  !
)OO! "
;OO" #
}PP 
}QQ 	
	_disposedSS 
=SS 
trueSS 
;SS 
}TT 
publicVV 

voidVV 
DisposeVV 
(VV 
)VV 
{WW 
DisposeXX 
(XX 
trueXX 
)XX 
;XX 
GCYY 

.YY
 
SuppressFinalizeYY 
(YY 
thisYY  
)YY  !
;YY! "
}ZZ 
}[[ Í
QC:\Users\WINDOWS\RiderProjects\TicketsAPI\Infrastructure\Security\Encrypt\Hash.cs
	namespace 	
Infrastructure
 
. 
Security !
.! "
Encrypt" )
;) *
public 
static 
class 
Hash 
{ 
public 

static 
string 
	GetSha256 "
(" #
string# )
value* /
)/ 0
{		 
var

 
sha256

 
=

 
SHA256

 
.

 
Create

 "
(

" #
)

# $
;

$ %
var 
encoding 
= 
new 
ASCIIEncoding (
(( )
)) *
;* +
var 
sb 
= 
new 
StringBuilder "
(" #
)# $
;$ %
var 
stream 
= 
sha256 
. 
ComputeHash '
(' (
encoding( 0
.0 1
GetBytes1 9
(9 :
value: ?
)? @
)@ A
;A B
foreach 
( 
var 
t 
in 
stream  
)  !
sb 
. 
Append 
( 
$" 
{ 
t 
: 
$str 
} 
" 
)  
;  !
return 
sb 
. 
ToString 
( 
) 
; 
} 
} ˜
RC:\Users\WINDOWS\RiderProjects\TicketsAPI\Infrastructure\Security\Jwt\IJwtUtils.cs
	namespace 	
Infrastructure
 
. 
Security !
.! "
Jwt" %
;% &
public 
	interface 
	IJwtUtils 
< 
in 
T 
>  
{ 
string 
GenerateJwtToken 
( 
T 
userDto "
)" #
;# $
Guid 
ValidateJwtToken 
( 
string 
token #
)# $
;$ %
} ê<
VC:\Users\WINDOWS\RiderProjects\TicketsAPI\Infrastructure\Security\Jwt\JwtMiddleware.cs
	namespace 	
Infrastructure
 
. 
Security !
.! "
Jwt" %
;% &
public 
class 
JwtMiddleware 
< 
T 
> 
{ 
private 
readonly 
RequestDelegate $
_next% *
;* +
private 
readonly 
AppSettings  
_appSettings! -
;- .
private 
readonly 
IMapper 
_mapper $
;$ %
public 

JwtMiddleware 
( 
RequestDelegate (
next) -
,- .
IOptions/ 7
<7 8
AppSettings8 C
>C D
appSettingsE P
,P Q
IMapperR Y
mapperZ `
)` a
{ 
_next 
= 
next 
; 
_mapper 
= 
mapper 
; 
_appSettings 
= 
appSettings "
." #
Value# (
;( )
} 
public 

async 
Task 
Invoke 
( 
HttpContext (
context) 0
,0 1
IGenericRepository2 D
<D E
UserE I
>I J
userRepositoryK Y
,Y Z
IGenericRepository   
<   
UserRole   #
>  # $
userRoleRepository  % 7
)  7 8
{!! 
var"" 
token"" 
="" 
context"" 
."" 
Request"" #
.""# $
Headers""$ +
[""+ ,
$str"", ;
]""; <
.""< =
FirstOrDefault""= K
(""K L
)""L M
?""M N
.""N O
Split""O T
(""T U
$str""U X
)""X Y
.""Y Z
Last""Z ^
(""^ _
)""_ `
;""` a
if$$ 

($$ 
token$$ 
!=$$ 
null$$ 
)$$ 
AttachUserToContext%% 
(%%  
context%%  '
,%%' (
userRepository%%) 7
,%%7 8
token%%9 >
,%%> ?
userRoleRepository%%@ R
)%%R S
;%%S T
await'' 
_next'' 
('' 
context'' 
)'' 
;'' 
}(( 
private** 
void** 
AttachUserToContext** $
(**$ %
HttpContext**% 0
context**1 8
,**8 9
IGenericRepository**: L
<**L M
User**M Q
>**Q R
userRepository**S a
,**a b
string**c i
token**j o
,**o p
IGenericRepository++ 
<++ 
UserRole++ #
>++# $
userRoleRepository++% 7
)++7 8
{,, 
try-- 
{.. 	
var// 
tokenHandler// 
=// 
new// "#
JwtSecurityTokenHandler//# :
(//: ;
)//; <
;//< =
var00 
key00 
=00 
Encoding00 
.00 
ASCII00 $
.00$ %
GetBytes00% -
(00- .
_appSettings00. :
.00: ;
Secret00; A
)00A B
;00B C
tokenHandler11 
.11 
ValidateToken11 &
(11& '
token11' ,
,11, -
new11. 1%
TokenValidationParameters112 K
{22 $
ValidateIssuerSigningKey33 (
=33) *
true33+ /
,33/ 0
IssuerSigningKey44  
=44! "
new44# & 
SymmetricSecurityKey44' ;
(44; <
key44< ?
)44? @
,44@ A
ValidateIssuer55 
=55  
false55! &
,55& '
ValidateAudience66  
=66! "
false66# (
,66( )
	ClockSkew77 
=77 
TimeSpan77 $
.77$ %
Zero77% )
}88 
,88 
out88 
var88 
validatedToken88 %
)88% &
;88& '
var:: 
jwtToken:: 
=:: 
(:: 
JwtSecurityToken:: ,
)::, -
validatedToken::- ;
;::; <
Guid;; 
.;; 
TryParse;; 
(;; 
jwtToken;; "
.;;" #
Claims;;# )
.;;) *
First;;* /
(;;/ 0
x;;0 1
=>;;2 4
x;;5 6
.;;6 7
Type;;7 ;
.;;; <
ToLower;;< C
(;;C D
);;D E
==;;F H
$str;;I M
);;M N
.;;N O
Value;;O T
,;;T U
out;;V Y
var;;Z ]
userId;;^ d
);;d e
;;;e f
if<< 
(<< 
userId<< 
==<< 
Guid<< 
.<< 
Empty<< $
)<<$ %
throw<<& +
new<<, /%
InvalidOperationException<<0 I
(<<I J
$str<<J d
)<<d e
;<<e f
var== 
user== 
=== 
GetUserInfo== "
(==" #
userRepository==# 1
,==1 2
userRoleRepository==3 E
,==E F
userId==G M
)==M N
;==N O
var>> 
userDto>> 
=>> 
_mapper>> !
.>>! "
Map>>" %
<>>% &
T>>& '
>>>' (
(>>( )
user>>) -
)>>- .
;>>. /
context?? 
.?? 
Items?? 
[?? 
$str??  
]??  !
=??" #
userDto??$ +
;??+ ,
}@@ 	
catchAA 
(AA 
	ExceptionAA 
eAA 
)AA 
{BB 	
throwCC 
newCC 
AppExceptionCC "
(CC" #
eCC# $
.CC$ %
MessageCC% ,
)CC, -
;CC- .
}DD 	
}EE 
privateGG 
staticGG 
asyncGG 
TaskGG 
<GG 
UserGG "
>GG" #
GetUserInfoGG$ /
(GG/ 0
IGenericRepositoryGG0 B
<GGB C
UserGGC G
>GGG H
userRepositoryGGI W
,GGW X
IGenericRepositoryHH 
<HH 
UserRoleHH #
>HH# $
userRoleRepositoryHH% 7
,HH7 8
GuidHH9 =
userIdHH> D
)HHD E
{II 
varJJ 
userJJ 
=JJ 
awaitJJ 
userRepositoryJJ '
.JJ' (
FindJJ( ,
(JJ, -
uJJ- .
=>JJ/ 1
uJJ2 3
.JJ3 4
IdJJ4 6
==JJ7 9
userIdJJ: @
,JJ@ A
falseJJB G
,JJG H
$strJJI T
)JJT U
;JJU V
varKK 
	userRolesKK 
=KK 
awaitLL 
userRoleRepositoryLL $
.LL$ %
GetAsyncLL% -
(LL- .
urLL. 0
=>LL1 3
urLL4 6
.LL6 7
UserIdLL7 =
==LL> @
userLLA E
.LLE F
IdLLF H
,LLH I
nullLLJ N
,LLN O
falseLLP U
,LLU V
$strLLW ]
)LL] ^
;LL^ _
userMM 
.MM 
RolesMM 
=MM 
	userRolesMM 
.MM 
SelectMM %
(MM% &
uMM& '
=>MM( *
uMM+ ,
.MM, -
RoleMM- 1
)MM1 2
;MM2 3
returnNN 
userNN 
;NN 
}OO 
}PP “/
QC:\Users\WINDOWS\RiderProjects\TicketsAPI\Infrastructure\Security\Jwt\JwtUtils.cs
	namespace 	
Infrastructure
 
. 
Security !
.! "
Jwt" %
;% &
public

 
class

 
JwtUtils

 
<

 
T

 
>

 
:

 
	IJwtUtils

 $
<

$ %
T

% &
>

& '
where

( -
T

. /
:

0 1
class

2 7
{ 
private 
readonly	 
AppSettings 
_appSettings *
;* +
public 
JwtUtils 
( 
IOptions 
< 
AppSettings %
>% &
appSettings' 2
)2 3
{ 
_appSettings 
= 
appSettings 
. 
Value "
;" #
} 
public 
string 
GenerateJwtToken 
(  
T  !
userDto" )
)) *
{ 
var 
propertyInfo 
= 
userDto 
. 
GetType $
($ %
)% &
.& '
GetProperty' 2
(2 3
$str3 7
)7 8
;8 9
if 
( 
propertyInfo 
== 
null 
) 
return "
$str# =
;= >
var 
id 
=	 

Guid 
. 
Parse 
( 
propertyInfo "
." #
GetValue# +
(+ ,
userDto, 3
)3 4
?4 5
.5 6
ToString6 >
(> ?
)? @
??A C
stringD J
.J K
EmptyK P
)P Q
;Q R
var 
tokenHandler 
= 
new #
JwtSecurityTokenHandler 0
(0 1
)1 2
;2 3
var 
key 	
=
 
Encoding 
. 
ASCII 
. 
GetBytes #
(# $
_appSettings$ 0
.0 1
Secret1 7
)7 8
;8 9
var 
tokenDescriptor 
= 
new #
SecurityTokenDescriptor 3
{ 
Subject 

= 
new 
ClaimsIdentity 
(  
new  #
[# $
]$ %
{ 
new 
Claim 
( 
$str 
, 
id 
. 
ToString 
(  
)  !
)! "
}   
)   
,   
Expires!! 

=!! 
DateTime!! 
.!! 
UtcNow!! 
.!! 
AddDays!! $
(!!$ %
$num!!% &
)!!& '
,!!' (
SigningCredentials"" 
="" 
new## 
SigningCredentials## 
(## 
new##  
SymmetricSecurityKey## 3
(##3 4
key##4 7
)##7 8
,##8 9
SecurityAlgorithms##: L
.##L M
HmacSha256Signature##M `
)##` a
}$$ 
;$$ 
var%% 
token%% 
=%% 
tokenHandler%% 
.%% 
CreateToken%% &
(%%& '
tokenDescriptor%%' 6
)%%6 7
;%%7 8
return&& 
tokenHandler&&	 
.&& 

WriteToken&&  
(&&  !
token&&! &
)&&& '
;&&' (
}'' 
public)) 
Guid)) 
ValidateJwtToken)) 
()) 
string)) $
?))$ %
token))& +
)))+ ,
{** 
if++ 
(++ 
token++ 
==++ 
null++ 
)++ 
return,, 	
Guid,,
 
.,, 
Empty,, 
;,, 
var.. 
tokenHandler.. 
=.. 
new.. #
JwtSecurityTokenHandler.. 0
(..0 1
)..1 2
;..2 3
var// 
key// 	
=//
 
Encoding// 
.// 
ASCII// 
.// 
GetBytes// #
(//# $
_appSettings//$ 0
.//0 1
Secret//1 7
)//7 8
;//8 9
try00 
{11 
tokenHandler22 
.22 
ValidateToken22 
(22 
token22 #
,22# $
new22% (%
TokenValidationParameters22) B
{33 $
ValidateIssuerSigningKey44 
=44 
true44 #
,44# $
IssuerSigningKey55 
=55 
new55  
SymmetricSecurityKey55 /
(55/ 0
key550 3
)553 4
,554 5
ValidateIssuer66 
=66 
false66 
,66 
ValidateAudience77 
=77 
false77 
,77 
	ClockSkew88 
=88 
TimeSpan88 
.88 
Zero88 
}99 
,99 
out99 	
var99
 
validatedToken99 
)99 
;99 
var;; 
jwtToken;; 
=;; 
(;; 
JwtSecurityToken;; #
);;# $
validatedToken;;$ 2
;;;2 3
var<< 
userId<< 
=<< 
Guid<< 
.<< 
Parse<< 
(<< 
jwtToken<< #
.<<# $
Claims<<$ *
.<<* +
First<<+ 0
(<<0 1
x<<1 2
=><<3 5
x<<6 7
.<<7 8
Type<<8 <
==<<= ?
$str<<@ D
)<<D E
.<<E F
Value<<F K
)<<K L
;<<L M
return>> 	
userId>>
 
;>> 
}?? 
catch@@ 
{AA 
returnBB 	
GuidBB
 
.BB 
EmptyBB 
;BB 
}CC 
}DD 
}EE 