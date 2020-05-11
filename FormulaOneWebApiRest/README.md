# Formula One Web API Rest
aaa

# Web Services
## TEAMS
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
<hr width="80%" align="center"/>

## DRIVERS
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