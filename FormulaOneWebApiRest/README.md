# Formula One Web API Rest
aaa

# Web Services
### TEAMS
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

### DRIVERS
**api/drivers/list**
```
api/drivers/list
[
  --same as: api/drivers/n/detail--,
  --same as: api/drivers/n/detail--
  ...
]
```

**api/drivers/1/detail
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