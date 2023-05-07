## Co aplikace/hra/bot dělá:
- ### Projekt je založen na hře Flappy bird, která vyšla roku 2013 a vytvořil ji Dong Nguyen během tří dní
- ### Hra je hlavně určena pro zábavu/zkrácení dlouhé chvíle
- ### Hráč hraje jako pták (Faby) a vertikálně létá tak, aby nenerazil do žádných překážek (trubek)
- ### Hra je nekonečná a hráčovi počítá skóre aby věděl kolik trubek proletěl
- ### Cílem hry je pochopitelně proletět co nejvíce trubkami, po smrti se hráčovi ukáže jeho nejlepší skóre

 ## Popis použitých technologií
 ### Na hru bylo použito: 
- ### Herní engine Unity ve verzi 2021.3.24
- ### Vývojové prostředí Microsoft Visual Studio 2022
- ### Textury oficiální hry Flappy Bird
- ### V případě vyskytlých errorů napomohlo ChatGPT 

 ## Stručný popis jak to funguje uvnitř
- ### Hráč ve skutečnosti stojí na místě a mezerníkem skáče do výšky detekuje kolize s překážkama (trubky + podlaha) a s colliderem, který je uprostřed trubky aby mohl započítat bod za průlet
- ### Trubky se objevují na předurčené pozici x a následně na náhodné pozici y, aby se objevovaly v různé výšce, trubky po objevení jedou doleva a po nějaké době se zničí aby se hra zbytečně nesekala
- ### Podlaha společně s ptákem mají animace aby to vypadalo, jako že pták létá a podlaha se hýbe společně s trubkama
- ### Ve hře jsou dvě scény, jedna před zapnutím hry kdy se neobjevují překážky a pták létá a druhá je samotná hra
- ### Když hráč umře tak se objeví menu a zastaví čas aby hra nepokračovala
- ### V momentě co hra skončí, tak v případě že dostal hráč nejvyšší skóre tak se integer pomocí PlayerPrefs uloží

 ## Návod na použití projektu
- ### Nejdřív si vybereme verzi a stáhneme projekt z githubu v sekci releases
- ### Repozitář si extrahujem a otevřem vybraný build
- ### Po spuštění programu stačí pouze zmáčknout mezerník, kterým se hra ovládá a nyní musíte být co nejlepší!

 ## Možný rozvoj v budoucnu/popis reálného využití projektu
- ### Flappy Bird je velmi jednoduchý a uzavřený koncept, takže pro rozvoj by byl nejlepší nový herní mód jako třeba že by pták neletěl do strany ale padal dolů, přitom co by se pořád vyhýbal trubkám
- ### Hráč by za určitý dosažený počet bodů mohl hráč dostat odměnu v podobě kosmetické úpravy
- ### Hra by také mohla mít světový žebříček, aby se hráči mezi sebou porovnávali
- ### Na hře by se mohlo AI vyučovat kdy dávat Input tak, aby dosáhlo co nejvyššího skóre, ale to je z reálného využití už asi tak všechno
