#@Integration
@UnitTest

Jellemző: CategoryService
	szükségem van egy olyan szervízre ami a Category adatok
	eléréséért és rendelkezésre bocsájtásáért felel.
Forgatókönyv: CategoryService Add függvény
	Adott a CategoryService
	Ha meghívom az Add függvényt ezekkel a paraméterekkel: 'egy új karegória neve'
	Akkor létrejön az új kategória ezzel a névvel : 'egy új karegória neve'

Forgatókönyv: CategoryService Find függvény
	Adott a CategoryService
	Ha meghívom a Find függvényt ezekkel a paraméterekkel: '1'
	Akkor megkapom a kért kategóriát
