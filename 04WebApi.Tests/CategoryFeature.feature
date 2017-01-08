Jellemző: Category kiszolgáló
	fejlesztőként szükségem van egy webapi-ra, ami
	kiszolgálja a Categóriákra vonatkozó kéréseket
Forgatókönyv vázlat: WebApiCategoryGet
	Adott egy böngésző
	Ha meghívjuk ezt a címet: <url>
	Akkor ezeket az adatokat kapjuk <id>,<name>
Példák: 
	| url          | id | name           |
	| 'Category/1' | 1  | 'Processzorok' |
	| 'Category/2' | 2  | 'Memóriák'     |
	| 'Category/3' | 3  | 'Monitorok'    |

Forgatókönyv vázlat: WebApiCategoryPost
	Adott egy böngésző
	Ha meghívjuk post-tal ezt a címet: <url> és átadjuk az értékeket : <key>, <value> 
	Akkor hiba nélkül lefut a kérés
Példák:
	| url        | key    | value             |
	| 'Category' | 'Name' | '1. új kategória' |
	| 'Category' | 'Name' | '2. új kategória' |  
	| 'Category' | 'Name' | '3. új kategória' |  
	| 'Category' | 'Name' | '4. új kategória' |  



