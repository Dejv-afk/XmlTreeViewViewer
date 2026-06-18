# Readme file for vocabulary
x = číslo

AO (Assembly) - stage, kde probíhá montáž racku
bit (binary digit) - základní jednotka digitální informace, tedy jeden bit může nabývat dvou logických hodnot v binární soustavě: 1 nebo 0, často uvádí jako rychlost přenosu dat v síti
Boot - je proces načítání a spouštění operačního systému, velmi zjednodušeně PWR ON > BIOS/UEFI > POST > MBR > OS Bootloader > OS, postup se může trochu lišit na typu zařízení a typu OS
Blade (L10) – celý počítač/jednotka ve tvaru desky se zabudovanými komponenty
BMC (Baseboard Management Control) – je čip na základní desce serveru, který umožňuje vzdálenou správu hardwaru bez nutnosti spuštění operačního systému, a MAC adresa přiřazená tomuto čipu slouží k jeho jednoznačné identifikaci a komunikaci v síti
BOM (Bill Of Materials) - kusovník, neboli seznam všech materiálů, dílů a podsestav potřebných k výrobě finálního produktu, slouží ke sledování, co je potřeba, kolik čeho a pro jaký produkt
BSL - poslední test funkčnosti firmware/software před Hi-Pot a následné balení
Byte - je 8 bitů, může tedy nabývat 256 hodnot
CP (Celestial Peak) - druh FPGA karty pro GEN 8
GP (Glacier Peak) - novější verze FPGA karty pro GEN 9
CATERR (Catastrophic Error) - nevratná hardwarová chyba, pokud LEDka na MB bliká, jedná se nejspíše o problém CPU nebo DIMM, dá se zjistit v SEL logu, pokud svítí stále, je to OK
CMOS (Complementary Metal-Oxide-Semiconductor) - (BIOS/RTC) je malá paměť na základní desce, která uchovává základní nastavení systému (datum, čas, konfigurace disků) i po vypnutí, díky napájení z baterie (např. CR2032).
COM port (COMmunication port) - dělí se na samčí/samičí (male/female) podobně jako RJ45, používá se pro sériový přenos dat (pozor neplést si s VGA)
CT - domluvený čas, do kdy se má stihnout fázi
CTS (Clear To Ship) - je portál, kde je přehled všech BOM, připravených na shipment
DDNSx (Dynamic Domain Name System) – specializovaný typ DNS, kdy automaticky aktualizuje doménové jméno při změně IP adresy, čímž zajišťuje neustálý přístup k síti nebo serveru pomocí stabilního názvu, což je ideální pro domácí sítě a VPN
DIMM (Dual In-Put Memory Module) - “dýmka” v podstatě RAMka, hardwarový komponent sloužící k dočasnému uložení dat. Při vypnutí se data smažou.
DNS (Domain Name System) - systém pro přepisování čitelných domén na IP adresy, např. dns.google > 8.8.8.8
DHCP (Dynamic Host Configuration Protocol) - je síťový protokol a služba, která automaticky přiděluje zařízením v síti IP adresy a další konfigurační informace, jako je maska podsítě, výchozí brána a adresy DNS serverů. Tímto způsobem centralizuje a zjednodušuje správu sítě, eliminuje nutnost ruční konfigurace každého zařízení a minimalizuje chyby
ECC (Error Correction Code) - technologie, která zjistí a opraví chybu za chodu počítače bez nutnosti vnějšího zásahu
FA (Failure Analyze) - oddělení pro analýzu chyb/poškození v hardwaru
FAT (File Allocation Table) - je jednoduchý souborový systém vytvořený pro DOS, tento systém stále využívá Linux a MS-DOS
IP (Internet Protocol) - internetová adresa, kterou si zařízení “vypůjčí” od DHCP, většinou je spjatá s fyzickou MAC adresou
IOIOI - symbol pro sériový port pro přenášení dat, tedy bitů za sebou jednou datovou linkou
ISP (Internet Service Provider) - poskytovatel internetových služeb
FA –
FPGA (Field Programmable Gate Array) - jedná se o typ integrovaného obvodu (karty), který může být programován uživatelem až po výrobě. To znamená, že se jeho vnitřní funkce mohou měnit a přizpůsobovat konkrétním potřebám aplikace
FRU - soubor základních informací každé jednotky
L11 PoT nebo-li Power-on Test (GEN 2), hovorově “pot” - je první test racku, kde se zjišťuje funkčnost kabeláže, PMDU včetně rack manageru, switchů, relátek či komunikace s blady. PoT také flashuje firmware RM, switchů, Y kabelů, a konfigurují se switche
M11 – linka Monica
MAC (Media Access Control) - “mek” fyzická adresa hardwaru (většinou síťová karta), která slouží k jeho jednoznačné identifikaci a komunikaci v síti
MD - druhá fáze testování Intel SHC MDaaS
MDaaS (Master Data as a Service?) - potřeba ověřit správnost
MFG/MfG (pravděpodobně ManufacturinG – hovorově running testování?
MFS -
MGMT1 (Managment) Switch – management switch napojený na všechny komponenty racku a slouží pro komunikaci a ovládání racku
MO - označení pro várku třeba 40 kusů racků nebo 100 bladů
MPA (Material Preparation Area) - areál, kde se připravuje materiál pro montáž bladů a racků
MSF - zkratka pro označení MicroSoFt
MW (Monitor Test) - poslední fáze testování MDaaS
M1 - předposlední fáze testování L10 MDaaS
NIC (Network Interface Card) – síťová karta “síťovka” se síťovým portem, nazývá se také jako síťový adaptér či LAN adaptér
NS1 - dolní TOR switch (U24)
NS2 - horní TOR switch (U26)
NTFS (New Technology File System) - souborový systém vyvinutý společností Microsoft, který převzal nékteré koncepty z HPFS
PCB (Printed Circuit Board) - fyzická deska z izolačního materiálu (např. sklolaminátu), na které jsou v měděné vrstvě vytvořeny vodivé cesty (stopy) pro propojení elektronických součástek
PDMU (Power Delivery Management Unit) – “totem” napájecí zdroj v racku, dává šťávu do bladů a switchů a reguluje proud do jednotek
PT TN TO TP N1 N2 QN RS MG – jednotlivé testovací fáze/stage, kterými musí rack projít než se přesune na další stanoviště
PT (Power Test) – test napájení racku
PXE (Preboot eXecution Enviroment) -
TN –
TO –
TP –
N1 – testování jednotlivých komponent v bladu
N2 –
QN –
RS –
MG (MDaaS Golden config) – první fáze testování v MDaaS
QSFP (Quad Small Form-factor Pluggable) – je kompaktní, vysokorychlostní, oboustranný, připojitelný (zasouvatelný) vysílač-přijímač používaný v síťových zařízeních pro propojení optických “optika” nebo měděných kabelů “metalika” (většinou krátké kvůli ceně). Tyto moduly se liší podporovanými přenosovými rychlostmi, například QSFP+ je pro 40 Gb/s a QSFP28 pro 100 Gb/s, zatímco QSFP-DD (Double Density) podporuje rychlosti až 400 Gb/s
Rack (česky rozvaděč) (L11) – skříň, resp. kovová věžitá konstrukce se zasunutými a propojenými „blady“ pro různé účely - sítě, zvukařinu atd.
RJ-45 (starší označení RJ-5) - koncovka s kroucenou linkou je dnes nejčastěji používaný typ zapojení pomocí síťových kabelů UTP (Unshielded Twisted Pair) a STP (Shielded Twisted Pair). Mimo to se ale používá ke spojení xDSL (Digital Subscriber Line) modemů, ISDN (Integrated Services Digital Network) zařízení, E1 atp. Vytlačila mnoho ostatních koncovek, z důvodu snižování počtu vodičů a modernizace počítačového vybavení. Je to koncovka typu 8P8C (z angličtiny: 8 pozic (8Positions), 8 vodičů (8Cables)). RJ-45 může mít dvě podoby: zásuvka (samičí, female, F) nebo zástrčka (samčí, male, M)
Více info ⇒ https://cs.wikipedia.org/wiki/RJ-45
RKxxx – umístění/pozice racku ve vestavku (RK = RacK, xxx = 3ciferné číslo pozice
RM (Rack Manager) – je hardware umístěný vzadu v racku pro komunikaci a ovládání
SCM (Smart Chassis Management/Server Control Module) - slouží k Out-Of-Band managementu > umožňuje ovládat server, i když je vypnutý nebo má zamrzlý operační systém
SEL (System Event Log) - je systémové hlášení událostí, kde se dá zjistit, kde se naskytla chyba
SN (Serial Number) – sériové číslo produktu
SOP (Standard Operation Procedure) - standardní postup, resp. návod, jak postupovat či řešit problém
SKU - Microsoft číselný identifikátor, něco jako PN pro nás
SU (Serial Number Upload) - po passnutí v MDaaS systém automaticky doplní sériová čísla bladů do SFCS
Switch – komponent, resp. přepínač uprostřed v racku s porty (vstupy/výstupy) do kterého se zapojují všechny kabely z bladů, dělí se na dva typy – datový a síťový
TOR (Top-Of-Rack) Switch – switch s QSFP porty na pozici U24 nebo U25. Záleží na verzi racku GEN8/9 nebo 10. Některé mají záložní switch na pozici U26. Tedy NS1 =
VPN (Virtual Private Network) - zabezpečuje a šifruje připojení na vzdálený server tzv. tunneling
USN (Unit Serial Number) – sériové číslo jednotky
UTP (Unshielded Twisted Pair) - nestíněná kroucená dvojlinka, nejčastěji označuje síťový kabel, který se používá k propojení počítačů v lokální síti nejčastěji pomocí koncovky RJ-45
UUT (Unit Under Test) - testovaná jednotka
WB (Waiting for BSL) – stage racku čekající na testování BSL
WL (Waiting for MDaaS) - stage racku čekající na testování MDaaS
WT (Waiting for Test) – stage, kdy rack čeká na spuštění testování (většinou připravený a zapojený ve vestavku)
Y-Cable - fialový QSFP kabel rozdvojený do dvou kabelů (má tvar jako písmeno Y)

