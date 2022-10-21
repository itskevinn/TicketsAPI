è
PC:\Users\WINDOWS\RiderProjects\TicketsAPI\Api\Extensions\AutoMapperExtensions.cs
	namespace 	
TicketsWebServices
 
. 

Extensions '
;' (
public 
static 
class  
AutoMapperExtensions (
{ 
public 

static 
IServiceCollection $
AddMappings% 0
(0 1
this1 5
IServiceCollection6 H
svcI L
)L M
{		 
var

 
mapperConfig

 
=

 
new

 
MapperConfiguration

 2
(

2 3
m

3 4
=>

5 7
{ 	
var 
profiles 
= 
new 
List #
<# $
Profile$ +
>+ ,
{ 
new 
MenuItemProfile #
(# $
)$ %
,% &
new' *
RoleProfile+ 6
(6 7
)7 8
,8 9
new: =
UserProfile> I
(I J
)J K
} 
; 
m 
. 
AddProfiles 
( 
profiles "
)" #
;# $
} 	
)	 

;
 
var 
mapper 
= 
mapperConfig !
.! "
CreateMapper" .
(. /
)/ 0
;0 1
svc 
. 
AddSingleton 
( 
mapper 
)  
;  !
return 
svc 
; 
} 
} Û

PC:\Users\WINDOWS\RiderProjects\TicketsAPI\Api\Extensions\PersistenceExtension.cs
	namespace 	
TicketsWebServices
 
. 

Extensions '
;' (
public 
static 
class !
PersistenceExtensions )
{		 
public

 

static

 
IServiceCollection

 $
AddPersistence

% 3
(

3 4
this

4 8
IServiceCollection

9 K
svc

L O
,

O P
IConfiguration

Q _
config

` f
)

f g
{ 
svc 
. 
AddTransient 
( 
typeof 
(  
IGenericRepository  2
<2 3
>3 4
)4 5
,5 6
typeof7 =
(= >
GenericRepository> O
<O P
>P Q
)Q R
)R S
;S T
svc 
. 
AddTransient 
< 
IDbConnection &
>& '
(' (
_( )
=>* ,
new- 0
SqlConnection1 >
(> ?
config? E
.E F
GetConnectionStringF Y
(Y Z
$strZ m
)m n
)n o
)o p
;p q
return 
svc 
; 
} 
} ‚
HC:\Users\WINDOWS\RiderProjects\TicketsAPI\Api\Extensions\RepoSettings.cs
	namespace 	
TicketsWebServices
 
. 

Extensions '
;' (
public 
sealed 
class 
RepoSettings  
{ 
public 
string 

SchemaName 
{ 
get 
;  
set! $
;$ %
}& '
=( )
default* 1
!1 2
;2 3
} ¢;
MC:\Users\WINDOWS\RiderProjects\TicketsAPI\Api\Extensions\ServiceExtensions.cs
	namespace 	
TicketsWebServices
 
. 

Extensions '
;' (
public 
static 
class 
ServiceExtensions %
{ 
public 
static 
IServiceCollection !
AddServices" -
(- .
this. 2
IServiceCollection3 E
servicesF N
)N O
=>P R
services 

.		 
AddServices		 
(		 
typeof		 
(		 
ITransientService		 (
)		( )
,		) *
ServiceLifetime		+ :
.		: ;
	Transient		; D
)		D E
;		E F
internal 	
static
 
IServiceCollection #
AddServices$ /
(/ 0
this0 4
IServiceCollection5 G
servicesH P
,P Q
TypeR V
interfaceTypeW d
,d e
ServiceLifetime 
lifetime 
) 
{ 
var 
interfaceTypes 
= 
	AppDomain 
. 
CurrentDomain 
. 
GetAssemblies (
(( )
)) *
. 

SelectMany 
( 
s 
=> 
s 
. 
GetTypes 
(  
)  !
)! "
. 
Where 

(
 
t 
=> 
interfaceType 
. 
IsAssignableFrom .
(. /
t/ 0
)0 1
&& 
t 
. 
IsClass 
&& 
!  !
t! "
." #

IsAbstract# -
)- .
. 
Select 
( 
t 
=> 
new 
{ 
Service 
= 
t 
. 
GetInterfaces 
( 
)  
.  !
FirstOrDefault! /
(/ 0
)0 1
,1 2
Implementation 
= 
t 
} 
) 
. 
Where 

(
 
t 
=> 
t 
. 
Service 
is 
not  
null! %
&& 
interfaceType  
.  !
IsAssignableFrom! 1
(1 2
t2 3
.3 4
Service4 ;
); <
)< =
;= >
foreach 	
(
 
var 
type 
in 
interfaceTypes %
)% &
{ 
services 
. 

AddService 
( 
type 
. 
Service #
!# $
,$ %
type& *
.* +
Implementation+ 9
,9 :
lifetime; C
)C D
;D E
} 
return   
services  	 
;   
}!! 
public## 
static## 
IServiceCollection## !
AddScopedServices##" 3
(##3 4
this##4 8
IServiceCollection##9 K
services##L T
)##T U
=>##V X
services$$ 

.%% 
AddScopedServices%% 
(%% 
typeof%% 
(%% 
IScopedService%% +
)%%+ ,
,%%, -
ServiceLifetime%%. =
.%%= >
Scoped%%> D
)%%D E
;%%E F
internal'' 	
static''
 
IServiceCollection'' #
AddScopedServices''$ 5
(''5 6
this''6 :
IServiceCollection''; M
services''N V
,''V W
Type''X \
interfaceType''] j
,''j k
ServiceLifetime(( 
lifetime(( 
)(( 
{)) 
var** 
interfaceTypes** 
=** 
	AppDomain++ 
.++ 
CurrentDomain++ 
.++ 
GetAssemblies++ (
(++( )
)++) *
.,, 

SelectMany,, 
(,, 
s,, 
=>,, 
s,, 
.,, 
GetTypes,, 
(,,  
),,  !
),,! "
.-- 
Where-- 

(--
 
t-- 
=>-- 
interfaceType-- 
.-- 
IsAssignableFrom-- .
(--. /
t--/ 0
)--0 1
&&.. 
t.. 
... 
IsClass.. 
&&.. 
!..  !
t..! "
..." #

IsAbstract..# -
)..- .
.// 
Select// 
(// 
t// 
=>// 
new// 
{00 
Service11 
=11 
t11 
.11 
GetInterfaces11 
(11 
)11  
.11  !
FirstOrDefault11! /
(11/ 0
)110 1
,111 2
Implementation22 
=22 
t22 
}33 
)33 
.44 
Where44 

(44
 
t44 
=>44 
t44 
.44 
Service44 
is44 
not44  
null44! %
&&55 
interfaceType55  
.55  !
IsAssignableFrom55! 1
(551 2
t552 3
.553 4
Service554 ;
)55; <
)55< =
;55= >
foreach77 	
(77
 
var77 
type77 
in77 
interfaceTypes77 %
)77% &
{88 
services99 
.99 

AddService99 
(99 
type99 
.99 
Service99 #
!99# $
,99$ %
type99& *
.99* +
Implementation99+ 9
,999 :
lifetime99; C
)99C D
;99D E
}:: 
return<< 
services<<	 
;<< 
}== 
internal?? 	
static??
 
IServiceCollection?? #

AddService??$ .
(??. /
this??/ 3
IServiceCollection??4 F
services??G O
,??O P
Type??Q U
serviceType??V a
,??a b
Type@@ 
implementationType@@ 
,@@ 
ServiceLifetime@@ *
lifetime@@+ 3
)@@3 4
=>@@5 7
lifetimeAA 

switchAA 
{BB 
ServiceLifetimeCC 
.CC 
	TransientCC 
=>CC 
servicesCC  (
.CC( )
AddTransientCC) 5
(CC5 6
serviceTypeCC6 A
,CCA B
implementationTypeCCC U
)CCU V
,CCV W
ServiceLifetimeDD 
.DD 
ScopedDD 
=>DD 
servicesDD %
.DD% &
	AddScopedDD& /
(DD/ 0
serviceTypeDD0 ;
,DD; <
implementationTypeDD= O
)DDO P
,DDP Q
ServiceLifetimeEE 
.EE 
	SingletonEE 
=>EE 
servicesEE  (
.EE( )
AddSingletonEE) 5
(EE5 6
serviceTypeEE6 A
,EEA B
implementationTypeEEC U
)EEU V
,EEV W
_FF 
=>FF 
throwFF 
newFF 
ArgumentExceptionFF #
(FF# $
$strFF$ 6
,FF6 7
nameofFF8 >
(FF> ?
lifetimeFF? G
)FFG H
)FFH I
}GG 
;GG 
}HH ¡
TC:\Users\WINDOWS\RiderProjects\TicketsAPI\Api\Filters\AppExceptionFilterAttribute.cs
	namespace 	
TicketsWebServices
 
. 
Filters $
;$ %
[ 
AttributeUsage 
( 
AttributeTargets  
.  !
All! $
)$ %
]% &
public		 
sealed		 
class		 '
AppExceptionFilterAttribute		 /
:		0 1$
ExceptionFilterAttribute		2 J
{

 
private 
readonly 
ILogger 
< '
AppExceptionFilterAttribute 8
>8 9
_logger: A
;A B
public 
'
AppExceptionFilterAttribute &
(& '
ILogger' .
<. /'
AppExceptionFilterAttribute/ J
>J K
loggerL R
)R S
{ 
_logger 
= 
logger 
; 
} 
public 

override 
void 
OnException $
($ %
ExceptionContext% 5
context6 =
)= >
{ 
{ 	
context 
. 
HttpContext 
.  
Response  (
.( )

StatusCode) 3
=4 5
context6 =
.= >
	Exception> G
switchH N
{ 
AppException 
=> 
(  !
(! "
int" %
)% &
HttpStatusCode& 4
.4 5

BadRequest5 ?
)? @
,@ A
_ 
=> 
( 
( 
int 
) 
HttpStatusCode )
.) *
InternalServerError* =
)= >
} 
; 
_logger 
. 
LogError 
( 
context $
.$ %
	Exception% .
,. /
context0 7
.7 8
	Exception8 A
.A B
MessageB I
,I J
newK N
[N O
]O P
{Q R
contextS Z
.Z [
	Exception[ d
.d e

StackTracee o
}p q
)q r
;r s
var 
msg 
= 
new 
{ 
context   
.   
	Exception   !
.  ! "
Message  " )
}!! 
;!! 
context## 
.## 
Result## 
=## 
new##  
ObjectResult##! -
(##- .
msg##. 1
)##1 2
;##2 3
}$$ 	
}%% 
}&& ÿ_
8C:\Users\WINDOWS\RiderProjects\TicketsAPI\Api\Program.cs
var 
builder 
= 
WebApplication 
. 
CreateBuilder *
(* +
args+ /
)/ 0
;0 1
const 
string "
myAllowSpecificOrigins #
=$ %
$str& ?
;? @
var 
config 

= 
builder 
. 
Configuration "
;" #
builder 
. 
Services 
. 
AddControllers 
(  
opts  $
=>% '
{( )
opts* .
.. /
Filters/ 6
.6 7
Add7 :
(: ;
typeof; A
(A B'
AppExceptionFilterAttributeB ]
)] ^
)^ _
;_ `
}a b
)b c
;c d
builder 
. 
Services 
. #
AddEndpointsApiExplorer (
(( )
)) *
.* +
AddMappings+ 6
(6 7
)7 8
;8 9
builder 
. 
Services 
. 
AddCors 
( 
options  
=>! #
{ 
options 
. 
	AddPolicy 
( 
name 
: "
myAllowSpecificOrigins 2
,2 3
corsPolicyBuilder 
=> 
{ 
corsPolicyBuilder 0
.0 1
AllowAnyOrigin1 ?
(? @
)@ A
.A B
AllowAnyHeaderB P
(P Q
)Q R
.R S
AllowAnyMethodS a
(a b
)b c
;c d
}e f
)f g
;g h
} 
) 
; 
builder 
. 
Services 
. 
AddSwaggerGen 
( 
c  
=>! #
{ 
var 
securityScheme 
= 
new !
OpenApiSecurityScheme 2
{ 
Name 
= 
$str #
,# $
Description   
=   
$str   9
,  9 :
In!! 

=!! 
ParameterLocation!! 
.!! 
Header!! %
,!!% &
Type"" 
="" 
SecuritySchemeType"" !
.""! "
Http""" &
,""& '
Scheme## 
=## 
$str## 
,## 
BearerFormat$$ 
=$$ 
$str$$ 
,$$ 
	Reference%% 
=%% 
new%% 
OpenApiReference%% (
{&& 	
Id'' 
='' 
JwtBearerDefaults'' "
.''" # 
AuthenticationScheme''# 7
,''7 8
Type(( 
=(( 
ReferenceType((  
.((  !
SecurityScheme((! /
,((/ 0
})) 	
}** 
;** 
c++ 
.++ !
AddSecurityDefinition++ 
(++ 
securityScheme++ *
.++* +
	Reference+++ 4
.++4 5
Id++5 7
,++7 8
securityScheme++9 G
)++G H
;++H I
c,, 
.,, "
AddSecurityRequirement,, 
(,, 
new,,  &
OpenApiSecurityRequirement,,! ;
{-- 
{.. 	
securityScheme..
 
,.. 
new.. 
string.. $
[..$ %
]..% &
{..' (
}..) *
}..+ ,
}// 
)// 
;// 
}00 
)00 
;00 
builder11 
.11 
Services11 
.11 
AddAutoMapper11 
(11 
Assembly11 '
.11' (
Load11( ,
(11, -
$str11- :
)11: ;
)11; <
;11< =
builder22 
.22 
Services22 
.22 
AddDbContext22 
<22 
TicketsContext22 ,
>22, -
(22- .
opt22. 1
=>222 4
{33 
opt44 
.44 
UseSqlServer44 
(44 
config44 
.44 
GetConnectionString44 /
(44/ 0
$str440 7
)447 8
,448 9
sqlOpts55 
=>55 
{55 
sqlOpts55 
.55 "
MigrationsHistoryTable55 3
(553 4
$str554 G
,55G H
config55I O
.55O P
GetValue55P X
<55X Y
string55Y _
>55_ `
(55` a
$str55a m
)55m n
)55n o
;55o p
}55q r
)55r s
;55s t
}66 
)66 
;66 
builder88 
.88 
Services88 
.88 
AddHealthChecks88  
(88  !
)88! "
.88" #
AddSqlServer88# /
(88/ 0
config880 6
[886 7
$str887 P
]88P Q
)88Q R
;88R S
builder:: 
.:: 
Services:: 
.:: 

AddLogging:: 
(:: 
loggingBuilder:: *
=>::+ -
loggingBuilder::. <
.::< =

AddSerilog::= G
(::G H
dispose::H O
:::O P
true::Q U
)::U V
)::V W
;::W X
builder<< 
.<< 
Services<< 
.<< 
AddPersistence<< 
(<<  
config<<  &
)<<& '
.<<' (
AddServices<<( 3
(<<3 4
)<<4 5
.<<5 6
AddScopedServices<<6 G
(<<G H
)<<H I
;<<I J
builder== 
.== 
Services== 
.== 
	AddScoped== 
(== 
typeof== !
(==! "
	IJwtUtils==" +
<==+ ,
>==, -
)==- .
,==. /
typeof==0 6
(==6 7
JwtUtils==7 ?
<==? @
>==@ A
)==A B
)==B C
;==C D
builder>> 
.>> 
Services>> 
.>> 
AddAuthorization>> !
(>>! "
)>>" #
;>># $
var@@ 
appSettingsSection@@ 
=@@ 
config@@ 
.@@  

GetSection@@  *
(@@* +
$str@@+ 8
)@@8 9
;@@9 :
builderAA 
.AA 
ServicesAA 
.AA 
	ConfigureAA 
<AA 
AppSettingsAA &
>AA& '
(AA' (
appSettingsSectionAA( :
)AA: ;
;AA; <
builderBB 
.BB 
ServicesBB 
.BB 
AddSingletonBB 
<BB  
IHttpContextAccessorBB 2
,BB2 3
HttpContextAccessorBB4 G
>BBG H
(BBH I
)BBI J
;BBJ K
varDD 
appSettingsDD 
=DD 
appSettingsSectionDD $
.DD$ %
GetDD% (
<DD( )
AppSettingsDD) 4
>DD4 5
(DD5 6
)DD6 7
;DD7 8
varEE 
keyEE 
=EE 	
EncodingEE
 
.EE 
ASCIIEE 
.EE 
GetBytesEE !
(EE! "
appSettingsEE" -
.EE- .
SecretEE. 4
)EE4 5
;EE5 6
builderFF 
.FF 
ServicesFF 
.FF 
AddAuthenticationFF "
(FF" #
xFF# $
=>FF% '
{GG 
xHH 	
.HH	 
%
DefaultAuthenticateSchemeHH
 #
=HH$ %
JwtBearerDefaultsHH& 7
.HH7 8 
AuthenticationSchemeHH8 L
;HHL M
xII 	
.II	 
"
DefaultChallengeSchemeII
  
=II! "
JwtBearerDefaultsII# 4
.II4 5 
AuthenticationSchemeII5 I
;III J
}JJ 
)JJ 
.KK 
AddJwtBearerKK 
(KK 
xKK 
=>KK 
{LL 
xMM 	
.MM	 
 
RequireHttpsMetadataMM
 
=MM  
falseMM! &
;MM& '
xNN 	
.NN	 

	SaveTokenNN
 
=NN 
trueNN 
;NN 
xOO 	
.OO	 
%
TokenValidationParametersOO
 #
=OO$ %
newOO& )%
TokenValidationParametersOO* C
{PP 	$
ValidateIssuerSigningKeyQQ $
=QQ% &
trueQQ' +
,QQ+ ,
IssuerSigningKeyRR 
=RR 
newRR " 
SymmetricSecurityKeyRR# 7
(RR7 8
keyRR8 ;
)RR; <
,RR< =
ValidateIssuerSS 
=SS 
falseSS "
,SS" #
ValidateAudienceTT 
=TT 
falseTT $
}UU 	
;UU	 

}VV 
)VV 
;VV 
builderWW 
.WW 
ServicesWW 
.WW 
AddSwaggerGenWW 
(WW 
cWW  
=>WW! #
{WW$ %
cWW& '
.WW' (

SwaggerDocWW( 2
(WW2 3
$strWW3 7
,WW7 8
newWW9 <
(WW< =
)WW= >
{WW? @
TitleWWA F
=WWG H
$strWWI V
,WWV W
VersionWWX _
=WW` a
$strWWb f
}WWg h
)WWh i
;WWi j
}WWk l
)WWl m
;WWm n
builderXX 
.XX 
ServicesXX 
.XX 
	ConfigureXX 
<XX 
AppSettingsXX &
>XX& '
(XX' (
builderXX( /
.XX/ 0
ConfigurationXX0 =
)XX= >
;XX> ?
LogZZ 
.ZZ 
LoggerZZ 

=ZZ 
newZZ 
LoggerConfigurationZZ $
(ZZ$ %
)ZZ% &
.ZZ& '
EnrichZZ' -
.ZZ- .
FromLogContextZZ. <
(ZZ< =
)ZZ= >
.[[ 
WriteTo[[ 
.[[ 
Console[[ 
([[ 
)[[ 
.\\ 
WriteTo\\ 
.\\ 
File\\ 
(\\ 
$"\\ 
$str\\  
{\\  !
DateTime\\! )
.\\) *
Now\\* -
.\\- .
Millisecond\\. 9
}\\9 :
$str\\: >
"\\> ?
,\\? @
rollingInterval\\A P
:\\P Q
RollingInterval\\R a
.\\a b
Day\\b e
)\\e f
.]] 
CreateLogger]] 
(]] 
)]] 
;]] 
var__ 
app__ 
=__ 	
builder__
 
.__ 
Build__ 
(__ 
)__ 
;__ 
ifaa 
(aa 
appaa 
.aa 
Environmentaa 
.aa 
IsDevelopmentaa !
(aa! "
)aa" #
)aa# $
{bb 
appcc 
.cc 

UseSwaggercc 
(cc 
)cc 
;cc 
appdd 
.dd 
UseSwaggerUIdd 
(dd 
cdd 
=>dd 
cdd 
.dd 
SwaggerEndpointdd +
(dd+ ,
$strdd, F
,ddF G
$strddH U
)ddU V
)ddV W
;ddW X
}ee 
appgg 
.gg 
UseMiddlewaregg 
<gg 
JwtMiddlewaregg 
<gg  
UserDtogg  '
>gg' (
>gg( )
(gg) *
)gg* +
;gg+ ,
apphh 
.hh 
UseCorshh 
(hh "
myAllowSpecificOriginshh "
)hh" #
;hh# $
appii 
.ii 

UseRoutingii 
(ii 
)ii 
;ii 
appjj 
.jj 
UseHttpLoggingjj 
(jj 
)jj 
;jj 
appkk 
.kk 
UseHttpsRedirectionkk 
(kk 
)kk 
;kk 
appll 
.ll 
UseAuthorizationll 
(ll 
)ll 
;ll 
appmm 
.mm 
UseAuthenticationmm 
(mm 
)mm 
;mm 
appnn 
.nn 
MapControllersnn 
(nn 
)nn 
;nn 
appoo 
.oo 
Runoo 
(oo 
)oo 	
;oo	 
