# Formula One Web API Rest
aaa

# Web Services
Semplification and analysis of the main web services

## TEAMS
Based on the Teams table
**api/teams/list**
```
[
    --same as: api/teams/n/detail--,
    --same as: api/teams/n/detail--
    ...
]
```

**api/teams/1/detail**
```
{
    name: "Mercedes",
    fullName: "Mercedes-AMG Petronas F1 Team",
    powerUnit: "Mercedes",
    technicalChief: "James Allison",
    chassis: "W11",
    logo: "svg format",
    img: "...",
    Drivers:
    [
        {firstname: "Lewis", lastName: "Hamilton", img: "..."},
        {firstname: "Valtteri", lastName: "Bottas", img: "..."}
    ]
}
```

## DRIVERS
Based on the Drivers table
**api/drivers/list**
```
api/drivers/list
[
    --same as: api/drivers/n/detail--,
    --same as: api/drivers/n/detail--
    ...
]
```

**api/drivers/1/detail**
```
{
    firstName: “Lewis”,
    lastName: “Hamilton”,
    Countries: {flag: “svg”, countryName: “United Kingdom”}
    number: “44”,
    image: “...”,
    pob: “Stevenage, England”,
    dob: “07/01/1985”,
    teamName: “Mercedes”
}
```

## RESULTS
Based on the Races_Scores table
**api/races-results/list**
```
[
    {
        Races: 
        {
            nLaps: “58”,
            grandPrixDate: “17/03/2019”,
            Countries: {countryName: “Australia”}
        },
        Drivers: {lastName: “Bottas”, firstName: “Valtteri”},
        Teams: {name: “Mercedes”},
        fastestLap: “1:25:27.325”
    },
    ...
]
```
Based on the Drivers table
**api/races-results/1/details**
```
[
    {
        Races_Scores: {position: “1”, fastestLap: “1:25:27.325”},
        Races: {nLaps: “58”},
        number: “77”,
        lastname: “Bottas”,
        firstname: “Valtteri”,
        Teams: {name: “Mercedes”},
        * Scores: {score: “26”} points sommati se 1° e giro veloce = 25+1
    },
    ...
]
```
Based on the Races_Scores table
**api/ranking/list**
```
[
    {
        position: “1”,
        Drivers: {firstName: “Lewis”, lastName: “Hamilton”},
        Countries: {countrCode: “UK”},
        Teams: {name: “Mercedes”},
        * points: Races Races_Scores calcolo dinamico score
    },
    ...
]
```

**api/ranking/1/detail**
```
[
    {
        Countries: {countryName: “Australia”},
        Races: {grandPrixDate: “17/03/2019”},
        Teams: {name: “Mercedes”},
        position: “2”,
        Scores: {score: “18”}
    },
    ...
]
```
Based on the Races_Scores table
**api/teams-results/list**
```
[
    {
        * position: Races Races_Scores calcolo dinamico punti, quindi sort
        * Teams: {name: “Mercedes”},
        * points: Races Races_Scores calcolo dinamico score
    },
    ...
]
```

**api/teams-results/list**
```
[
    {
        Countries: {countryName: “Australia”},
        Races: {grandPrixDate: “17/03/2019”}
        * points: Races Races_Scores calcolo dinamico score
    },
    ...
]
```

## CIRCUITS
Based on the Circuits table
**api/circuits/list**
```
[
    --same as: api/circuits/n/detail--,
    --same as: api/circuits/n/detail--,
    ...
]
```

**api/circuits/1/detail**
```
{
    name: “Melbourne Grand Prix Circuit”,
    Countries: {countryName: “Australia”}
    length: “5303”,
    recordLap: “1.24.125”,
    img: “...”,
    firstGrandPrix: “1996”,
    Races:
    {
        grandPrixDate: “17/03/2019”,
        grandPrixName: “Formula 1 Rolex Australian Grand Prix 2019”,
        nLaps: “58”
    }
}
```