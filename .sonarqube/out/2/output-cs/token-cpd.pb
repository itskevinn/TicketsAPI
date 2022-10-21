

IC:\Users\WINDOWS\RiderProjects\TicketsAPI\Application\Base\BaseService.cs
	namespace 	
Application
 
. 
Base 
; 
public 
class 
BaseService 
{ 
	protected 
const 
string "
AnErrorHappenedMessage 1
=2 3
$str4 F
;F G
private		 
readonly		  
IHttpContextAccessor		 )
?		) *
_contextAccessor		+ ;
;		; <
	protected 
BaseService 
( 
) 
{ 
} 
	protected 
BaseService 
(  
IHttpContextAccessor 
context $
)$ %
{ 
_contextAccessor 
= 
context "
;" #
} 
	protected 
UserDto 
GetCurrentUser $
($ %
)% &
{ 
var 
value 
= 
( 
UserDto 
) 
_contextAccessor -
?- .
.. /
HttpContext/ :
?: ;
.; <
Items< A
[A B
$strB H
]H I
!I J
;J K
return 
value 
; 
} 
} ”
TC:\Users\WINDOWS\RiderProjects\TicketsAPI\Application\Security\AuthorizeAttribute.cs
	namespace 	
Application
 
. 
Security 
; 
[ 
AttributeUsage 
( 
AttributeTargets  
.  !
Class! &
|' (
AttributeTargets) 9
.9 :
Method: @
)@ A
]A B
public 
class 
AuthorizeAttribute 
:  !
	Attribute" +
,+ , 
IAuthorizationFilter- A
{		 
private

 
readonly

 
string

 
[

 
]

 
_validRoles

 )
;

) *
public 

AuthorizeAttribute 
( 
string $
[$ %
]% &

validRoles' 1
)1 2
{ 
_validRoles 
= 

validRoles  
;  !
} 
public 

void 
OnAuthorization 
(  &
AuthorizationFilterContext  :
context; B
)B C
{ 
var 
user 
= 
( 
UserDto 
) 
context #
.# $
HttpContext$ /
./ 0
Items0 5
[5 6
$str6 <
]< =
!= >
;> ?
{ 	
IEnumerable 
< 
RoleDto 
>  
	userRoles! *
=+ ,
new- 0
List1 5
<5 6
RoleDto6 =
>= >
(> ?
)? @
;@ A
foreach 
( 
var 
role 
in  
_validRoles! ,
), -
{ 
	userRoles 
= 
user  
.  !
Roles! &
.& '
Where' ,
(, -
r- .
=>/ 1
r2 3
.3 4
RoleName4 <
=== ?
role@ D
)D E
;E F
} 
if 
( 
! 
	userRoles 
. 
Any 
( 
)  
)  !
{ 
context 
. 
Result 
=  
new! $
UnauthorizedResult% 7
(7 8
)8 9
;9 :
} 
} 	
}   
}!! Ô
ZC:\Users\WINDOWS\RiderProjects\TicketsAPI\Application\Security\Http\Dto\AuthenticateDto.cs
	namespace 	
Application
 
. 
Security 
. 
Http #
.# $
Dto$ '
;' (
public 
class 
AuthenticateDto 
{ 
public 

Guid 
Id 
{ 
get 
; 
set 
; 
}  
public 

string 
Name 
{ 
get 
; 
set !
;! "
}# $
public 

string 
Username 
{ 
get  
;  !
set" %
;% &
}' (
public 

string 
Token 
{ 
get 
; 
set "
;" #
}$ %
public		 

IEnumerable		 
<		 
RoleDto		 
>		 
Roles		  %
{		& '
get		( +
;		+ ,
set		- 0
;		0 1
}		2 3
=		4 5
default		6 =
!		= >
;		> ?
public 

AuthenticateDto 
( 
UserDto "
user# '
,' (
string) /
token0 5
)5 6
{ 
Id 

= 
user 
. 
Id 
; 
Name 
= 
user 
. 
Name 
; 
Username 
= 
user 
. 
Username  
;  !
Roles 
= 
user 
. 
Roles 
; 
Token 
= 
token 
; 
} 
} ‘

VC:\Users\WINDOWS\RiderProjects\TicketsAPI\Application\Security\Http\Dto\MenuItemDto.cs
	namespace 	
Application
 
. 
Security 
. 
Http #
.# $
Dto$ '
;' (
public 
class 
MenuItemDto 
{ 
public 
Guid 
Id 
{ 
get 
; 
set 
; 
} 
public 
string 
Icon 
{ 
get 
; 
set 
; 
}  !
=" #
default$ +
!+ ,
;, -
public 
string 
Label 
{ 
get 
; 
set 
;  
}! "
=# $
default% ,
!, -
;- .
public 
int 
Order 
{ 
get 
; 
set 
; 
} 
=  !
default" )
!) *
;* +
public		 
string		 

RouterLink		 
{		 
get		 
;		  
set		! $
;		$ %
}		& '
=		( )
default		* 1
!		1 2
;		2 3
}

 ⁄
RC:\Users\WINDOWS\RiderProjects\TicketsAPI\Application\Security\Http\Dto\RoleDto.cs
	namespace 	
Application
 
. 
Security 
. 
Http #
.# $
Dto$ '
;' (
public 
class 
RoleDto 
{ 
public 

Guid 
Id 
{ 
get 
; 
set 
; 
}  
public 

string 
RoleName 
{ 
get  
;  !
set" %
;% &
}' (
=) *
default+ 2
!2 3
;3 4
public 

IEnumerable 
< 
MenuItemDto "
>" #
Authorities$ /
{0 1
get2 5
;5 6
set7 :
;: ;
}< =
=> ?
default@ G
!G H
;H I
} à
RC:\Users\WINDOWS\RiderProjects\TicketsAPI\Application\Security\Http\Dto\UserDto.cs
	namespace 	
Application
 
. 
Security 
. 
Http #
.# $
Dto$ '
;' (
public 
class 
UserDto 
{ 
public 

Guid 
Id 
{ 
get 
; 
set 
; 
}  
public 

string 
Name 
{ 
get 
; 
set !
;! "
}# $
=% &
default' .
!. /
;/ 0
public 

string 
RoleName 
{ 
get  
;  !
set" %
;% &
}' (
=) *
default+ 2
!2 3
;3 4
public 

string 
Username 
{ 
get  
;  !
set" %
;% &
}' (
=) *
default+ 2
!2 3
;3 4
public		 

IEnumerable		 
<		 
RoleDto		 
>		 
Roles		  %
{		& '
get		( +
;		+ ,
set		- 0
;		0 1
}		2 3
=		4 5
default		6 =
!		= >
;		> ?
}

 €
_C:\Users\WINDOWS\RiderProjects\TicketsAPI\Application\Security\Http\Profiles\MenuItemProfile.cs
	namespace 	
Application
 
. 
Security 
. 
Http #
.# $
Profiles$ ,
;, -
public 
class 
MenuItemProfile 
: 
Profile &
{ 
public		 

MenuItemProfile		 
(		 
)		 
{

 
	CreateMap 
< 
MenuItem 
, 
MenuItemDto '
>' (
(( )
)) *
.* +

ReverseMap+ 5
(5 6
)6 7
;7 8
} 
} ∏
[C:\Users\WINDOWS\RiderProjects\TicketsAPI\Application\Security\Http\Profiles\RoleProfile.cs
	namespace 	
Application
 
. 
Security 
. 
Http #
.# $
Profiles$ ,
;, -
public 
class 
RoleProfile 
: 
Profile "
{ 
public		 

RoleProfile		 
(		 
)		 
{

 
	CreateMap 
< 
Role 
, 
RoleDto 
>  
(  !
)! "
." #

ReverseMap# -
(- .
). /
. 
	ForMember 
( 
r 
=> 
r 
. 
Authorities )
,) *
a+ ,
=> 
a 
. 
MapFrom 
( 
ar 
=>  "
ar# %
.% &
Authorities& 1
)1 2
)2 3
;3 4
} 
} Ù
[C:\Users\WINDOWS\RiderProjects\TicketsAPI\Application\Security\Http\Profiles\UserProfile.cs
	namespace 	
Application
 
. 
Security 
. 
Http #
.# $
Profiles$ ,
;, -
public 
class 
UserProfile 
: 
Profile "
{		 
public

 

UserProfile

 
(

 
)

 
{ 
	CreateMap 
< 
UserRequest 
, 
User #
># $
($ %
)% &
.& '

ReverseMap' 1
(1 2
)2 3
;3 4
	CreateMap 
< 
UserUpdateRequest #
,# $
User% )
>) *
(* +
)+ ,
., -

ReverseMap- 7
(7 8
)8 9
;9 :
	CreateMap 
< 
User 
, 
UserDto 
>  
(  !
)! "
." #

ReverseMap# -
(- .
). /
. 
	ForMember 
( 
r 
=> 
r 
. 
Roles #
,# $
u% &
=> 
u 
. 
MapFrom 
( 
ur 
=>  "
ur# %
.% &
Roles& +
)+ ,
), -
;- .
} 
} è
bC:\Users\WINDOWS\RiderProjects\TicketsAPI\Application\Security\Http\Request\AuthenticateRequest.cs
	namespace 	
Application
 
. 
Security 
. 
Http #
.# $
Request$ +
;+ ,
public 
class 
AuthenticateRequest  
{ 
[ 
Required 
] 
public 

string 
Username 
{ 
get  
;  !
set" %
;% &
}' (
=) *
default+ 2
!2 3
;3 4
[

 
Required

 
]

 
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
;3 4
} ™
ZC:\Users\WINDOWS\RiderProjects\TicketsAPI\Application\Security\Http\Request\UserRequest.cs
	namespace 	
Application
 
. 
Security 
. 
Http #
.# $
Request$ +
;+ ,
public 
class 
UserRequest 
{ 
public 

string 
Name 
{ 
get 
; 
set !
;! "
}# $
=% &
default' .
!. /
;/ 0
public 

string 
Username 
{ 
get  
;  !
set" %
;% &
}' (
=) *
default+ 2
!2 3
;3 4
public 

string 
Password 
{ 
get  
;  !
set" %
;% &
}' (
=) *
default+ 2
!2 3
;3 4
public 

string 
	CreatedBy 
{ 
get !
;! "
set# &
;& '
}( )
=* +
default, 3
!3 4
;4 5
public		 

Guid		 
RoleId		 
{		 
get		 
;		 
set		 !
;		! "
}		# $
=		% &
default		' .
!		. /
;		/ 0
}

 Ç
`C:\Users\WINDOWS\RiderProjects\TicketsAPI\Application\Security\Http\Request\UserUpdateRequest.cs
	namespace 	
Application
 
. 
Security 
. 
Http #
.# $
Request$ +
;+ ,
public 
class 
UserUpdateRequest 
:  
UserRequest! ,
{ 
public 

Guid 
Id 
{ 
get 
; 
set 
; 
}  
public 

string 
	UpdatedBy 
{ 
get !
;! "
set# &
;& '
}( )
=* +
default, 3
!3 4
;4 5
} °
VC:\Users\WINDOWS\RiderProjects\TicketsAPI\Application\Security\Service\IAuthService.cs
	namespace 	
Application
 
. 
Security 
. 
Service &
;& '
public 
	interface 
IAuthService 
: 
IScopedService  .
{		 
Task

 
<

 	
Response

	 
<

 
AuthenticateDto

 !
>

! "
>

" #
Authenticate

$ 0
(

0 1
AuthenticateRequest

1 D
authenticateRequest

E X
)

X Y
;

Y Z
Task 
< 	
UserDto	 
> 
GetOnlyUserById !
(! "
Guid" &
id' )
)) *
;* +
} Í3
dC:\Users\WINDOWS\RiderProjects\TicketsAPI\Application\Security\Service\Implementation\AuthService.cs
	namespace 	
Application
 
. 
Security 
. 
Service &
.& '
Implementation' 5
;5 6
public 
class 
AuthService 
: 
BaseService &
,& '
IAuthService( 4
{ 
private 
readonly 
IGenericRepository '
<' (
User( ,
>, -
_userRepository. =
;= >
private 
readonly 
IGenericRepository '
<' (
UserRole( 0
>0 1
_userRoleRepository2 E
;E F
private 
readonly 
IMapper 
_mapper $
;$ %
private 
readonly 
	IJwtUtils 
< 
UserDto &
>& '
	_jwtUtils( 1
;1 2
private 
readonly 
IUserService !
_userService" .
;. /
public 

AuthService 
( 
IGenericRepository )
<) *
User* .
>. /
userRepository0 >
,> ?
IGenericRepository 
< 
UserRole #
># $
userRoleRepository% 7
,7 8
IUserService 
userService  
,  !
IMapper" )
mapper* 0
,0 1
	IJwtUtils 
< 
UserDto 
> 
jwtUtils #
)# $
{ 
_userRepository 
= 
userRepository (
;( )
_userRoleRepository 
= 
userRoleRepository 0
;0 1
_userService 
= 
userService "
;" #
_mapper 
= 
mapper 
; 
	_jwtUtils   
=   
jwtUtils   
;   
}!! 
public## 

async## 
Task## 
<## 
Response## 
<## 
AuthenticateDto## .
>##. /
>##/ 0
Authenticate##1 =
(##= >
AuthenticateRequest##> Q
authenticateRequest##R e
)##e f
{$$ 
var%% 
users%% 
=%% 
await%% 
_userRepository%% )
.%%) *
GetAsync%%* 2
(%%2 3
)%%3 4
;%%4 5
var&& 
user&& 
=&& 
users&& 
.&& 
SingleOrDefault&& (
(&&( )
x&&) *
=>&&+ -
string'' 
.'' 
Equals'' 
('' 
x'' 
.'' 
Username'' $
,''$ %
authenticateRequest''& 9
.''9 :
Username'': B
,''B C
StringComparison''D T
.''T U$
CurrentCultureIgnoreCase''U m
)''m n
&&''o q
x(( 
.(( 
Password(( 
==(( 
Hash(( 
.(( 
	GetSha256(( (
(((( )
authenticateRequest(() <
.((< =
Password((= E
)((E F
)((F G
;((G H
if)) 

()) 
user)) 
==)) 
null)) 
))) 
return** 
new** 
Response** 
<**  
AuthenticateDto**  /
>**/ 0
(**0 1
HttpStatusCode**1 ?
.**? @
Unauthorized**@ L
,**L M
$str**N p
,**p q
false++ 
)++ 
;++ 
var,, 
userDto,, 
=,, 
_userService,, "
.,," #
GetById,,# *
(,,* +
user,,+ /
.,,/ 0
Id,,0 2
),,2 3
.,,3 4
Result,,4 :
.,,: ;
Data,,; ?
;,,? @
var-- 
token-- 
=-- 
	_jwtUtils-- 
.-- 
GenerateJwtToken-- .
(--. /
userDto--/ 6
)--6 7
;--7 8
return.. 
new.. 
Response.. 
<.. 
AuthenticateDto.. +
>..+ ,
(.., -
HttpStatusCode..- ;
...; <
OK..< >
,..> ?
$str..@ L
,..L M
true..N R
,..R S
new// 
AuthenticateDto// 
(//  
userDto//  '
,//' (
token//) .
)//. /
)/// 0
;//0 1
}00 
public22 

async22 
Task22 
<22 
UserDto22 
>22 
GetOnlyUserById22 .
(22. /
Guid22/ 3
id224 6
)226 7
{33 
var44 
user44 
=44 
await44 
_userRepository44 (
.44( )
Find44) -
(44- .
u44. /
=>440 2
u443 4
.444 5
Id445 7
==448 :
id44; =
,44= >
false44? D
,44D E
$str44F Q
)44Q R
;44R S
var55 
	userRoles55 
=55 
await66 
_userRoleRepository66 %
.66% &
GetAsync66& .
(66. /
ur66/ 1
=>662 4
ur665 7
.667 8
UserId668 >
==66? A
user66B F
.66F G
Id66G I
,66I J
null66K O
,66O P
false66Q V
,66V W
$str66X ^
)66^ _
;66_ `
var77 
roles77 
=77 
new77 
List77 
<77 
Role77 !
>77! "
(77" #
)77# $
;77$ %
	userRoles88 
.88 
ToList88 
(88 
)88 
.88 
ForEach88 "
(88" #
u88# $
=>88% '
{88( )
roles88* /
.88/ 0
Add880 3
(883 4
u884 5
.885 6
Role886 :
)88: ;
;88; <
}88= >
)88> ?
;88? @
user99 
.99 
Roles99 
=99 
roles99 
;99 
var:: 
userDto:: 
=:: 
_mapper:: 
.:: 
Map:: !
<::! "
UserDto::" )
>::) *
(::* +
user::+ /
)::/ 0
;::0 1
return;; 
userDto;; 
;;; 
}<< 
}== áp
dC:\Users\WINDOWS\RiderProjects\TicketsAPI\Application\Security\Service\Implementation\UserService.cs
	namespace 	
Application
 
. 
Security 
. 
Service &
.& '
Implementation' 5
;5 6
public 
class 
UserService 
: 
BaseService &
,& '
IUserService( 4
{ 
private 
readonly 
IGenericRepository '
<' (
User( ,
>, -
_userRepository. =
;= >
private 
readonly 
IMapper 
_mapper $
;$ %
private 
readonly 
IGenericRepository '
<' (
UserRole( 0
>0 1
_userRoleRepository2 E
;E F
private 
readonly 
IGenericRepository '
<' (
MenuItem( 0
>0 1
_menuItemRepository2 E
;E F
private 
readonly 
IGenericRepository '
<' (
MenuItemRole( 4
>4 5#
_menuItemRoleRepository6 M
;M N
public 

UserService 
( 
IMapper 
mapper %
,% &
IUnitOfWork 

unitOfWork 
,  
IHttpContextAccessor 
accessor %
) 
: 
base 
( 
accessor 
) 
{ 
_mapper 
= 
mapper 
?? 
throw !
new" %!
ArgumentNullException& ;
(; <
$"< >
{> ?
nameof? E
(E F
mapperF L
)L M
}M N
"N O
)O P
;P Q
_userRepository 
= 

unitOfWork $
.$ %
UserRepository% 3
??4 6
throw 
new  #!
ArgumentNullException$ 9
(9 :
$": <
{< =
nameof= C
(C D

unitOfWorkD N
)N O
}O P
"P Q
)Q R
;R S
_menuItemRepository 
= 

unitOfWork (
.( )
MenuItemRepository) ;
??< >
throw? D
newE H!
ArgumentNullExceptionI ^
(^ _
$"_ a
{a b
nameofb h
(h i

unitOfWorki s
)s t
}t u
"u v
)v w
;w x
}   
public"" 

async"" 
Task"" 
<"" 
Response"" 
<"" 
UserDto"" &
>""& '
>""' (
Save"") -
(""- .
UserRequest"". 9
userRequest"": E
)""E F
{## 
try$$ 
{%% 	
var&& 
user&& 
=&& 
_mapper&& 
.&& 
Map&& "
<&&" #
User&&# '
>&&' (
(&&( )
userRequest&&) 4
)&&4 5
;&&5 6
user'' 
.'' 
Password'' 
='' 
Hash''  
.''  !
	GetSha256''! *
(''* +
user''+ /
.''/ 0
Password''0 8
)''8 9
;''9 :
user(( 
=(( 
await(( 
_userRepository(( (
.((( )
CreateAsync(() 4
(((4 5
user((5 9
)((9 :
;((: ;
await)) 
_userRoleRepository)) %
.))% &
CreateAsync))& 1
())1 2
new))2 5
UserRole))6 >
())> ?
user))? C
.))C D
Id))D F
,))F G
userRequest))H S
.))S T
RoleId))T Z
)))Z [
)))[ \
;))\ ]
var** 
userDto** 
=** 
_mapper** !
.**! "
Map**" %
<**% &
UserDto**& -
>**- .
(**. /
user**/ 3
)**3 4
;**4 5
return++ 
new++ 
Response++ 
<++  
UserDto++  '
>++' (
(++( )
HttpStatusCode++) 7
.++7 8
OK++8 :
,++: ;
$str++< P
,++P Q
true++R V
,++V W
userDto++X _
)++_ `
;++` a
},, 	
catch-- 
(-- 
	Exception-- 
e-- 
)-- 
{.. 	
return// 
new// 
Response// 
<//  
UserDto//  '
>//' (
(//( )
HttpStatusCode//) 7
.//7 8
InternalServerError//8 K
,//K L"
AnErrorHappenedMessage//M c
,//c d
false//e j
,//j k
null//l p
!//p q
,//q r
e//s t
)//t u
;//u v
}00 	
}11 
public33 

async33 
Task33 
<33 
Response33 
<33 
IEnumerable33 *
<33* +
UserDto33+ 2
>332 3
>333 4
>334 5
GetAll336 <
(33< =
)33= >
{44 
try55 
{66 	
var77 
users77 
=77 
await77 
_userRepository77 -
.77- .
GetAsync77. 6
(776 7
null777 ;
,77; <
null77= A
,77A B
false77C H
,77H I
$str77J d
)77d e
;77e f
var88 
userDtoList88 
=88 
_mapper88 %
.88% &
Map88& )
<88) *
IEnumerable88* 5
<885 6
UserDto886 =
>88= >
>88> ?
(88? @
users88@ E
)88E F
;88F G
return99 
new99 
Response99 
<99  
IEnumerable99  +
<99+ ,
UserDto99, 3
>993 4
>994 5
(:: 
HttpStatusCode:: 
.::  
OK::  "
,::" #
$str::$ :
,::: ;
true::< @
,::@ A
userDtoList::B M
)::M N
;::N O
};; 	
catch<< 
(<< 
	Exception<< 
e<< 
)<< 
{== 	
return>> 
new>> 
Response>> 
<>>  
IEnumerable>>  +
<>>+ ,
UserDto>>, 3
>>>3 4
>>>4 5
(>>5 6
HttpStatusCode>>6 D
.>>D E
InternalServerError>>E X
,>>X Y"
AnErrorHappenedMessage>>Z p
,>>p q
false?? 
,?? 
null?? 
!?? 
,?? 
e?? 
)??  
;??  !
}@@ 	
}AA 
publicCC 

asyncCC 
TaskCC 
<CC 
ResponseCC 
<CC 
UserDtoCC &
>CC& '
>CC' (
FindByIdCC) 1
(CC1 2
GuidCC2 6
idCC7 9
)CC9 :
{DD 
varEE 
currentUserEE 
=EE 
GetCurrentUserEE (
(EE( )
)EE) *
;EE* +
ifFF 

(FF 
currentUserFF 
==FF 
nullFF 
!FF  
)FF  !
returnGG 
newGG 
ResponseGG 
<GG  
UserDtoGG  '
>GG' (
(GG( )
HttpStatusCodeGG) 7
.GG7 8
UnauthorizedGG8 D
,GGD E
$strGGF W
,GGW X
falseGGY ^
)GG^ _
;GG_ `
ifHH 

(HH 
idHH 
!=HH 
currentUserHH 
.HH 
IdHH  
&&HH! #
currentUserII 
.II 
RolesII 
?II 
.II 
FirstII $
(II$ %
rII% &
=>II' )
rII* +
.II+ ,
RoleNameII, 4
==II5 7
$strII8 ?
)II? @
.II@ A
RoleNameIIA I
!=IIJ L
$strIIM T
)IIT U
returnJJ 
newJJ 
ResponseJJ 
<JJ  
UserDtoJJ  '
>JJ' (
(JJ( )
HttpStatusCodeJJ) 7
.JJ7 8
UnauthorizedJJ8 D
,JJD E
$strJJF Z
,JJZ [
falseJJ\ a
)JJa b
;JJb c
returnKK 
awaitKK 
GetByIdKK 
(KK 
idKK 
)KK  
;KK  !
}LL 
publicNN 

asyncNN 
TaskNN 
<NN 
ResponseNN 
<NN 
UserDtoNN &
>NN& '
>NN' (
GetByIdNN) 0
(NN0 1
GuidNN1 5
idNN6 8
)NN8 9
{OO 
tryPP 
{QQ 	
varRR 
userRR 
=RR 
awaitRR 
_userRepositoryRR ,
.RR, -
FindRR- 1
(RR1 2
uRR2 3
=>RR4 6
uRR7 8
.RR8 9
IdRR9 ;
==RR< >
idRR? A
,RRA B
falseRRC H
,RRH I
$strRRJ U
)RRU V
;RRV W
varSS 
userDtoSS 
=SS 
awaitSS 
SetUserRolesSS  ,
(SS, -
userSS- 1
)SS1 2
;SS2 3
varTT 
authoritiesTT 
=TT 
newTT !
ListTT" &
<TT& '
MenuItemTT' /
>TT/ 0
(TT0 1
)TT1 2
;TT2 3
SetRoleAuthoritiesUU 
(UU 
userDtoUU &
,UU& '
authoritiesUU( 3
)UU3 4
;UU4 5
returnVV 
newVV 
ResponseVV 
<VV  
UserDtoVV  '
>VV' (
(WW 
HttpStatusCodeWW 
.WW  
OKWW  "
,WW" #
$strWW$ 8
,WW8 9
trueWW: >
,WW> ?
userDtoWW@ G
)WWG H
;WWH I
}XX 	
catchYY 
(YY 
	ExceptionYY 
eYY 
)YY 
{ZZ 	
return[[ 
new[[ 
Response[[ 
<[[  
UserDto[[  '
>[[' (
([[( )
HttpStatusCode[[) 7
.[[7 8
InternalServerError[[8 K
,[[K L"
AnErrorHappenedMessage[[M c
,[[c d
false\\ 
,\\ 
null\\ 
!\\ 
,\\ 
e\\ 
)\\  
;\\  !
}]] 	
}^^ 
private`` 
async`` 
Task`` 
<`` 
UserDto`` 
>`` 
SetUserRoles``  ,
(``, -
User``- 1
user``2 6
)``6 7
{aa 
varbb 
	userRolesbb 
=bb 
awaitcc 
_userRoleRepositorycc %
.cc% &
GetAsynccc& .
(cc. /
urcc/ 1
=>cc2 4
urcc5 7
.cc7 8
UserIdcc8 >
==cc? A
userccB F
.ccF G
IdccG I
,ccI J
nullccK O
,ccO P
falseccQ V
,ccV W
$strccX ^
)cc^ _
;cc_ `
vardd 
rolesdd 
=dd 
newdd 
Listdd 
<dd 
Roledd !
>dd! "
(dd" #
)dd# $
;dd$ %
	userRolesee 
.ee 
ToListee 
(ee 
)ee 
.ee 
ForEachee "
(ee" #
uee# $
=>ee% '
{ee( )
rolesee* /
.ee/ 0
Addee0 3
(ee3 4
uee4 5
.ee5 6
Roleee6 :
)ee: ;
;ee; <
}ee= >
)ee> ?
;ee? @
userff 
.ff 
Rolesff 
=ff 
rolesff 
;ff 
vargg 
userDtogg 
=gg 
_mappergg 
.gg 
Mapgg !
<gg! "
UserDtogg" )
>gg) *
(gg* +
usergg+ /
)gg/ 0
;gg0 1
returnhh 
userDtohh 
;hh 
}ii 
privatekk 
voidkk 
SetRoleAuthoritieskk #
(kk# $
UserDtokk$ +
userDtokk, 3
,kk3 4
ICollectionkk5 @
<kk@ A
MenuItemkkA I
>kkI J
authoritieskkK V
)kkV W
{ll 
foreachmm 
(mm 
varmm 
userDtoRolemm  
inmm! #
userDtomm$ +
.mm+ ,
Rolesmm, 1
)mm1 2
{nn 	
varoo 
roleMenuItemsoo 
=oo #
_menuItemRoleRepositorypp '
.pp' (
GetAsyncpp( 0
(pp0 1
mpp1 2
=>pp3 5
mpp6 7
.pp7 8
RoleIdpp8 >
==pp? A
userDtoRoleppB M
.ppM N
IdppN P
)ppP Q
.ppQ R
ResultppR X
.ppX Y
ToListppY _
(pp_ `
)pp` a
;ppa b
roleMenuItemsqq 
.qq 
ForEachqq !
(qq! "
rqq" #
=>qq$ &
{rr 
authoritiesss 
.ss 
Addss 
(ss  
_menuItemRepositoryss  3
.ss3 4
GetAsyncss4 <
(ss< =
mss= >
=>ss? A
mssB C
.ssC D
IdssD F
==ssG I
rssJ K
.ssK L

MenuItemIdssL V
)ssV W
.ssW X
ResultssX ^
.ss^ _
MinByss_ d
(ssd e
msse f
=>ssg i
mssj k
.ssk l
Orderssl q
)ssq r
??sss u
throwtt  %
newtt& )%
InvalidOperationExceptiontt* C
(ttC D
)ttD E
)ttE F
;ttF G
}uu 
)uu 
;uu 
varvv 
authoritiesDtovv 
=vv  
_mappervv! (
.vv( )
Mapvv) ,
<vv, -
IEnumerablevv- 8
<vv8 9
MenuItemDtovv9 D
>vvD E
>vvE F
(vvF G
authoritiesvvG R
)vvR S
;vvS T
userDtoRoleww 
.ww 
Authoritiesww #
=ww$ %
authoritiesDtoww& 4
;ww4 5
}xx 	
}yy 
}zz ›
VC:\Users\WINDOWS\RiderProjects\TicketsAPI\Application\Security\Service\IUserService.cs
	namespace 	
Application
 
. 
Security 
. 
Service &
;& '
public 
	interface 
IUserService 
: 
ITransientService  1
{		 
public

 

Task

 
<

 
Response

 
<

 
UserDto

  
>

  !
>

! "
GetById

# *
(

* +
Guid

+ /
id

0 2
)

2 3
;

3 4
public 

Task 
< 
Response 
< 
IEnumerable $
<$ %
UserDto% ,
>, -
>- .
>. /
GetAll0 6
(6 7
)7 8
;8 9
public 

Task 
< 
Response 
< 
UserDto  
>  !
>! "
Save# '
(' (
UserRequest( 3
userRequest4 ?
)? @
;@ A
} ’
YC:\Users\WINDOWS\RiderProjects\TicketsAPI\Application\Tickets\Http\Dto\TicketDetailDto.cs
	namespace 	
Application
 
. 
Tickets 
. 
Http "
." #
Dto# &
;& '
public 
class 
TicketDetailDto 
{ 
public 

string 
Message 
{ 
get 
;  
set! $
;$ %
}& '
=( )
default* 1
!1 2
;2 3
public 

IEnumerable 
< 
	IFormFile  
>  !
AttachmentsUrls" 1
{2 3
get4 7
;7 8
set9 <
;< =
}> ?
=@ A
defaultB I
!I J
;J K
}		 Ü
SC:\Users\WINDOWS\RiderProjects\TicketsAPI\Application\Tickets\Http\Dto\TicketDto.cs
	namespace 	
Application
 
. 
Tickets 
. 
Http "
." #
Dto# &
;& '
public 
class 
	TicketDto 
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

UserDto 
GeneratedBy 
{  
get! $
;$ %
set& )
;) *
}+ ,
=- .
default/ 6
!6 7
;7 8
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
;6 7
public 

IEnumerable 
< 
TicketDetailDto &
>& '
TicketDetails( 5
{6 7
get8 ;
;; <
set= @
;@ A
}B C
=D E
defaultF M
!M N
;N O
} ®
bC:\Users\WINDOWS\RiderProjects\TicketsAPI\Application\Tickets\Http\Profiles\TicketDetailProfile.cs
	namespace 	
Application
 
. 
Tickets 
. 
Http "
." #
Profiles# +
;+ ,
public 
class 
TicketDetailProfile  
:! "
Profile# *
{ 
public		 

TicketDetailProfile		 
(		 
)		  
{

 
	CreateMap 
< 
TicketDetail 
, 
TicketDetailDto  /
>/ 0
(0 1
)1 2
;2 3
} 
} ä
\C:\Users\WINDOWS\RiderProjects\TicketsAPI\Application\Tickets\Http\Profiles\TicketProfile.cs
	namespace 	
Application
 
. 
Tickets 
. 
Http "
." #
Profiles# +
;+ ,
public 
class 
TicketProfile 
: 
Profile $
{ 
public		 

TicketProfile		 
(		 
)		 
{

 
	CreateMap 
< 
Ticket 
, 
	TicketDto #
># $
($ %
)% &
;& '
} 
} ·
aC:\Users\WINDOWS\RiderProjects\TicketsAPI\Application\Tickets\Http\Request\TicketDetailRequest.cs
	namespace 	
Application
 
. 
Tickets 
. 
Http "
." #
Request# *
;* +
public 
class 
TicketDetailRequest  
{ 
public 

string 
Message 
{ 
get 
;  
set! $
;$ %
}& '
=( )
default* 1
!1 2
;2 3
public 

IEnumerable 
< 
	IFormFile  
>  !
Attachments" -
{. /
get0 3
;3 4
set5 8
;8 9
}: ;
=< =
default> E
!E F
;F G
}		 ø
[C:\Users\WINDOWS\RiderProjects\TicketsAPI\Application\Tickets\Http\Request\TicketRequest.cs
	namespace 	
Application
 
. 
Tickets 
. 
Http "
." #
Request# *
;* +
public 
class 
TicketRequest 
{ 
public 

string 
Title 
{ 
get 
; 
set "
;" #
}$ %
=& '
default( /
!/ 0
;0 1
public 

string 
Message 
{ 
get 
;  
set! $
;$ %
}& '
=( )
default* 1
!1 2
;2 3
public 

string 
Status 
{ 
get 
; 
set  #
;# $
}% &
=' (
default) 0
!0 1
;1 2
public 

string 
GeneratedBy 
{ 
get  #
;# $
set% (
;( )
}* +
=, -
default. 5
!5 6
;6 7
public		 

DateTime		 
GeneratedOn		 
{		  !
get		" %
;		% &
set		' *
;		* +
}		, -
public

 

DateTime

 
SolvedOn

 
{

 
get

 "
;

" #
set

$ '
;

' (
}

) *
public 

DateTime 
AllegedSolveDate $
{% &
get' *
;* +
set, /
;/ 0
}1 2
public 

string 
Description 
{ 
get  #
;# $
set% (
;( )
}* +
=, -
default. 5
!5 6
;6 7
public 

IEnumerable 
< 
TicketDetailRequest *
>* +
TicketDetails, 9
{: ;
get< ?
;? @
setA D
;D E
}F G
=H I
defaultJ Q
!Q R
;R S
} Ü
aC:\Users\WINDOWS\RiderProjects\TicketsAPI\Application\Tickets\Http\Request\TicketUpdateRequest.cs
	namespace 	
Application
 
. 
Tickets 
. 
Http "
." #
Request# *
;* +
public 
class 
UpdateTicketRequest  
:! "
TicketRequest# 0
{ 
public 

Guid 
Id 
{ 
get 
; 
set 
; 
}  
public 

string 
	UpdatedBy 
{ 
get !
;! "
set# &
;& '
}( )
=* +
default, 3
!3 4
;4 5
} Ï%
eC:\Users\WINDOWS\RiderProjects\TicketsAPI\Application\Tickets\Service\Implementation\TicketService.cs
	namespace

 	
Application


 
.

 
Tickets

 
.

 
Service

 %
.

% &
Implementation

& 4
;

4 5
public 
class 
TicketService 
: 
BaseService (
,( )
ITicketService* 8
{ 
private 
readonly 
ITicketRepository &
_ticketRepository' 8
;8 9
private 
readonly 
IMapper 
_mapper $
;$ %
private 
readonly 
ILogger 
_logger $
;$ %
public 

TicketService 
( 
IUnitOfWork $

unitOfWork% /
,/ 0
IMapper1 8
mapper9 ?
,? @
ILoggerA H
loggerI O
)O P
{ 
_ticketRepository 
= 

unitOfWork &
.& '
TicketRepository' 7
??8 :
throw !
new" %!
ArgumentNullException& ;
(; <
nameof< B
(B C

unitOfWorkC M
)M N
,N O
$strP d
)d e
;e f
_mapper 
= 
mapper 
?? 
throw !
new" %!
ArgumentNullException& ;
(; <
nameof< B
(B C
mapperC I
)I J
,J K
$strL b
)b c
;c d
_logger 
= 
logger 
; 
} 
public 

async 
Task 
< 
IEnumerable !
<! "
	TicketDto" +
>+ ,
>, -
GetAllAsync. 9
(9 :
): ;
{ 
try 
{ 	
var 
tickets 
= 
await 
_ticketRepository  1
.1 2
GetAsync2 :
(: ;
); <
;< =
var 
ticketDtoList 
= 
_mapper  '
.' (
Map( +
<+ ,
IEnumerable, 7
<7 8
	TicketDto8 A
>A B
>B C
(C D
ticketsD K
.K L
AsEnumerableL X
(X Y
)Y Z
)Z [
;[ \
return   
ticketDtoList    
;    !
}!! 	
catch"" 
("" 
	Exception"" 
e"" 
)"" 
{## 	
_logger$$ 
.$$ 
Log$$ 
($$ 
LogLevel$$  
.$$  !
Error$$! &
,$$& '
$str$$( M
,$$M N"
AnErrorHappenedMessage$$O e
,$$e f
e$$g h
.$$h i
Message$$i p
)$$p q
;$$q r
return%% 
new%% 
List%% 
<%% 
	TicketDto%% %
>%%% &
(%%& '
)%%' (
;%%( )
}&& 	
}'' 
public)) 

async)) 
Task)) 
<)) 
	TicketDto)) 
>))  
GetByIdAsync))! -
())- .
string)). 4
code))5 9
)))9 :
{** 
try++ 
{,, 	
var-- 
ticket-- 
=-- 
await-- 
_ticketRepository-- 0
.--0 1
FindByCodeAsync--1 @
(--@ A
code--A E
)--E F
;--F G
var.. 
ticketDtoList.. 
=.. 
_mapper..  '
...' (
Map..( +
<..+ ,
	TicketDto.., 5
>..5 6
(..6 7
ticket..7 =
)..= >
;..> ?
return// 
ticketDtoList//  
;//  !
}00 	
catch11 
(11 
	Exception11 
e11 
)11 
{22 	
_logger33 
.33 
Log33 
(33 
LogLevel33  
.33  !
Error33! &
,33& '
$str33( M
,33M N"
AnErrorHappenedMessage33O e
,33e f
e33g h
.33h i
Message33i p
)33p q
;33q r
return44 
null44 
!44 
;44 
}55 	
}66 
public88 

Task88 
<88 
	TicketDto88 
>88 
CreateAsync88 &
(88& '
TicketRequest88' 4
request885 <
)88< =
{99 
throw:: 
new:: #
NotImplementedException:: )
(::) *
)::* +
;::+ ,
};; 
}<< Ú
WC:\Users\WINDOWS\RiderProjects\TicketsAPI\Application\Tickets\Service\ITicketService.cs
	namespace 	
Application
 
. 
Tickets 
. 
Service %
;% &
public 
	interface 
ITicketService 
{ 
Task 
< 	
IEnumerable	 
< 
	TicketDto 
> 
>  
GetAllAsync! ,
(, -
)- .
;. /
Task		 
<		 	
	TicketDto			 
>		 
GetByIdAsync		  
(		  !
string		! '
code		( ,
)		, -
;		- .
Task

 
<

 	
	TicketDto

	 
>

 
CreateAsync

 
(

  
TicketRequest

  -
request

. 5
)

5 6
;

6 7
} 