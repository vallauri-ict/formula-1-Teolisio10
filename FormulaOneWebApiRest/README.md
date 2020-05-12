# Formula One Web API Rest
This is the main project that access a localhost site

# Web Services
Semplification and analysis of the main web services

## TEAMS
Based on the Teams table<br/>
**api/teams/list**
```
[
    logo: "svg format",
    name: "Mercedes",
    Drivers:
    [
        {firstname: "Lewis", lastName: "Hamilton"},
        {firstname: "Valtteri", lastName: "Bottas"}
    ]
]
```

**api/teams/1/detail**
```
{
    logo: "svg format",
    name: "Mercedes",
    fullName: "Mercedes-AMG Petronas F1 Team",
    powerUnit: "Mercedes",
    technicalChief: "James Allison",
    chassis: "W11",
    Drivers:
    [
        {firstname: "Lewis", lastName: "Hamilton", img: "...", number: "44"},
        {firstname: "Valtteri", lastName: "Bottas", img: "...", number: "77"}
    ]
}
```

## DRIVERS
Based on the Drivers table<br/>
**api/drivers/list**
```
api/drivers/list
[
    number: "44",
    firstName: "Lewis",
    lastName: "Hamilton",
    image: "...",
    Teams: {name: "Mercedes"}
]
```

**api/drivers/1/detail**
```
{
    number: "44",
    firstName: "Lewis",
    lastName: "Hamilton",
    dob: "07/01/1985",
    pob: "Stevenage, England",
    image: "...",
    Countries: {flag: "svg", countryName: "United Kingdom"}
    teamName: "Mercedes"
}
```

## CIRCUITS
Based on the Circuits table<br/>
**api/circuits/list**
```
[
    name: "Melbourne Grand Prix Circuit",
    Countries: {countryName: "Australia"},
    img: "..."
]
```

**api/circuits/1/detail**
```
{
    name: "Melbourne Grand Prix Circuit",
    city: "Melbourne",
    Countries: {countryName: "Australia"}
    length: "5303",
    recordLap: "1.24.125",
    img: "...",
    firstGrandPrix: "1996",
    Races:
    {
        grandPrixDate: "17/03/2019",
        grandPrixName: "Formula 1 Rolex Australian Grand Prix 2019",
        nLaps: "58"
    }
}
```

## RESULTS
Based on the Races_Scores table<br/>
**api/races-results/list**
```
[
    {
        Countries: {countryName: "Australia"}
        Races: 
        {
            nLaps: "58",
            grandPrixDate: "17/03/2019",
        },
        Drivers: {lastName: "Bottas", firstName: "Valtteri"},
        Teams: {name: "Mercedes"},
        fastestLap: "1:25:27.325"
    },
    ...
]
```
Based on the Drivers table<br/>
**api/races-results/1/details**
```
[
    {
        Races_Scores: {position: "1", fastestLap: "1:25:27.325"},
        Races: {nLaps: "58"},
        number: "77",
        lastname: "Bottas",
        firstname: "Valtteri",
        Teams: {name: "Mercedes"},
        * Scores: {score: "26"} points sommati se 1° e giro veloce = 25+1
    },
    ...
]
```
Based on the Races_Scores table<br/>
**api/ranking/list**
```
[
    {
        position: "1",
        Drivers: {firstName: "Lewis", lastName: "Hamilton"},
        Countries: {countrCode: "UK"},
        Teams: {name: "Mercedes"},
        * points: Races Races_Scores calcolo dinamico score
    },
    ...
]
```

**api/ranking/1/detail**
```
[
    {
        Countries: {countryName: "Australia"},
        Races: {grandPrixDate: "17/03/2019"},
        Teams: {name: "Mercedes"},
        position: "2",
        Scores: {score: "18"}
    },
    ...
]
```
Based on the Races_Scores table<br/>
**api/teams-results/list**
```
[
    {
        * position: Races Races_Scores calcolo dinamico punti, quindi sort
        * Teams: {name: "Mercedes"},
        * points: Races Races_Scores calcolo dinamico score
    },
    ...
]
```

**api/teams-results/list**
```
[
    {
        Countries: {countryName: "Australia"},
        Races: {grandPrixDate: "17/03/2019"}
        * points: Races Races_Scores calcolo dinamico score
    },
    ...
]
```