# Co aplikace/hra/bot dělá:

- ### Tato hra je projekt založený na klasické hře Flappy Bird, kterou vytvořil Dong Nguyen v roce 2013 během pouhých tří dnů, Flappy Bird se stal velmi populární díky své jednoduchosti a návykovosti
- ### Hlavním účelem této hry je nabídnout hráčům zábavu a možnost zkrácení dlouhých chvil, kdy je potřeba se nějak odreagovat
- ### Hráč se v této hře stane ptákem jménem Faby, který se musí pohybovat vertikálně a vyhýbat se překážkám (trubk8m a podlaze), hráči musí používat své reflexy a koordinaci rukou a očí, aby se vyhnuli překážkám a pokračovali ve hře
- ### Hra je navržena tak, aby byla nekonečná, to znamená, že hráč může hrát tak dlouho, jak chce a jeho skóre se bude neustále zvyšovat s každou překonanou překážkou
- ### Cílem hry je samozřejmě co nejdéle přežít a proletět co nejvíce trubkami, po smrti se hráči ukáže jeho nejlepší dosažené skóre, což může hráče motivovat k dalšímu pokusu o překonání svého osobního rekordu

 # Popis použitých technologií
 
 ### Na hru bylo použito: 
 ## Herní engine Unity ve verzi 2021.3.24
- ### Herní engine je softwareová platforma, která umožňuje vývojářům vytvářet videohry a jiné interaktivní aplikace. Unity je jedním z nejpopulárnějších herních enginů na světě, který podporuje vývoj pro různé platformy, včetně PC, mobilních zařízení, herních konzolí a VR/AR headsetů, osobně jsem pracoval ve Verzi 2021.3.24, což jedna z novějších verzí Unity, která nabízí řadu nových funkcí a vylepšení výkonu a stability
 ## Vývojové prostředí Microsoft Visual Studio 2022
 - ### Microsoft Visual Studio je integrované vývojové prostředí (IDE), které se používá pro vývoj aplikací pro platformy Windows, Android, iOS a další, Visual Studio poskytuje široké spektrum funkcí pro programování, jako je například kódování, ladění, testování, správa verzí, a mnoho dalšího, verze 2022 je nejnovější verze Visual Studia, která přináší řadu nových funkcí a vylepšení výkonu a produktivity
 ## Textury oficiální hry Flappy Bird
 - ### Hra Flappy Bird byla vytvořena jedním vývojářem během pouhých tří dnů, což se promítlo i do grafické stránky hry, textury byly navrženy tak, aby byly jednoduché a velmi ikonické
 ## ChatGPT 
 - ### ChatGPT je velký jazykový model trénovaný na bázi GPT-3.5 architektury od společnosti OpenAI, tento model je schopný odpovídat na širokou škálu dotazů a poskytovat užitečné informace v různých oblastech, včetně programování a vývoje her, v případě vyskytlých errorů může být ChatGPT užitečným nástrojem pro řešení problémů a poskytování doporučení pro vylepšení hry

 # Stručný popis jak to funguje uvnitř
 
- ### Hráč ve skutečnosti stojí na místě a mezerníkem skáče do výšky detekuje kolize s překážkama (trubky + podlaha) a s colliderem, který je uprostřed trubky aby mohl započítat bod za průlet, Toho je docíleno pomocí RigidBody komponentu, a Collider komponentu, který zajišťuje detekci kolizí s objekty ve hře
- ### Trubky jsou generovány náhodně, aby hra byla každým spuštěním různá, toho se dociluje tím, že jsou trubky na náhodných pozicích v ose y, když se objevují na předem určené pozici x, když se trubky objeví na herní ploše, začnou se pohybovat doleva a po určité době se zničí, aby nezatěžovaly paměť hry
- ### Animace ptáka a podlahy přidávají do hry vizuální prvky, které ji dělají více atraktivní, animace jsou realizovány pomocí komponentu Animator, která řídí různé stavy animací a jejich přechody, tyto animace spolu s pohybem trubek vytváří dojem, že hráč letí skrz prostor
- ### Ve hře jsou dvě scény, přičemž jedna zobrazuje pouze úvodní obrazovku, ve které pták nepadá dolů a neobjevují se překážky a druhá samotnou hru, tímto se zajišťuje plynulý přechod mezi začátkem a samotnou hrou
- ### Když hráč zemře, tak se objeví menu a zastaví se čas aby hra nemohlo nadále pokračovat v pozadí dokud hráč nezačne znovu
- ### V momentě co hra skončí, tak v případě, že hráš dosáhl nejvyššího skóre tak se integer pomocí PlayerPrefs uloží

 # Návod na použití projektu
 
 ## Krok 1: Vyberte si verzi projektu a stáhněte si ji z Githubu
- ### Projekt Flappy Bird v Unity je k dispozici na Githubu v sekci releases, na této stránce jsou k dispozici různé verze projektu, z nichž si můžete vybrat tu nejaktuálnější, stáhněte si vybranou verzi projektu
 ## Krok 2: Extrahujte si repozitář a otevřete vybraný build
- ### Po stažení projektu jej extrahujte ze zip souboru na váš počítač, v repozitáři projektu budou obsaženy všechny potřebné soubory a složky, které budete potřebovat pro spuštění projektu, otevřete složku s vaší vybranou verzí projektu a najděte soubor s koncovkou ".exe", tento soubor slouží jako spouštěč projektu a po spuštění se vám zobrazí okno s herním prostředím
 ## Krok 3: Spusťte a ovládejte hru pomocí mezerníku
- ### Po úspěšném spuštění projektu můžete hru ovládat pomocí klávesy mezerník, cílem hry je posunout se co nejdále možno tím, že se klikáním na klávesu mezerníku necháte postavu skákat/létat tak, aby se vyhnula překážkám, pokud narazíte do překážky, hra končí
 ## Krok 4: Vylepšte své schopnosti a zlepšujte své skóre
- ### Hra Flappy Bird je jednoduchá, ale návyková, vyžaduje rychlost, preciznost a dobrou koordinaci, hrajte a zkoušejte různé strategie, jak se dostat co nejdále a překonat své předchozí skóre!

 # Možný rozvoj v budoucnu/popis reálného využití projektu
 
- ### Flappy Bird je velmi jednoduchý a uzavřený koncept, takže pro rozvoj by byly nejlepší nové herní režimy, které by nabízely hráčům různé způsoby, jak si užít hru, například by se mohl přidat náročnější herní režim, který by obsahoval více překážek, nebo by pták mohl padat dolů během toho, co se vyhýbá trubkám
- ### Další možností by byla implementace systému odměn pro hráče, za určitý dosažený počet bodů by hráč mohl získat kosmetickou úpravu pro svého ptáka, což by zvyšovalo motivaci hráčů hrát více a snažit se dosáhnout co nejvyššího skóre
- ### Pro hráče by mohlo být také zajímavé porovnávat své skóre s ostatními hráči pomocí světového žebříčku, to by mohlo vést k větší soutěživosti a snaze hráčů dosáhnout co nejvyššího skóre
- ### Na hře by se mohlo AI vyučovat kdy dávat Input tak, aby dosáhlo co nejvyššího skóre, ale jinak reálná využití hra moc nemá, jelikož je velmi jednoduchá
