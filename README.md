# PersonnummerValidering

## Beskrivning
Detta projekt är en konsolapplikation skriven i C# som verifierar om ett givet svenskt personnummer är giltigt. Applikationen är byggd för att hantera korrekt formaterade personnummer enligt svenska regler.

---

## Funktioner
- Validerar svenska personnummer enligt Luhn-algoritmen.
- Hanterar felaktiga format och ogiltiga personnummer.
- Enhetstester med NUnit för att säkerställa korrekt funktionalitet.
- Automatiserade tester och CI/CD-processer med GitHub Actions.
- Docker-container för enkel distribution.

---

## Svenska regler för personnummer
Ett svenskt personnummer har formatet `YYYYMMDD-XXXX` och består av:
1. **Födelsedatum (YYYYMMDD):**
   - År, månad och dag.
2. **Separatortecken (- eller +):**
   - `-` för personer under 100 år.
   - `+` för personer över 100 år.
3. **Slutdelen (XXXX):**
   - Ett fyrsiffrigt löpnummer där sista siffran är en kontrollsiffra baserad på Luhn-algoritmen.

Mer information: [Personnummer i Sverige (Wikipedia)](https://sv.wikipedia.org/wiki/Personnummer_i_Sverige)

---

## Så här kör du applikationen lokalt

### **Förutsättningar**
- **.NET SDK** installerad (minst version 6.0).
- Git installerat på din dator.

### **1. Klona projektet**
```bash
git clone https://github.com/<ditt-användarnamn>/PersonnummerValidering.git
cd PersonnummerValidering
