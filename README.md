# lottery
Web API 2 project of a lottery ticket system.


##APIs##

#####Get the last drawn numbers.#####
```GET ../api/lottery```

#####Draw new numbers.#####
```POST ../api/lottery```

#####Check if ticket is a winner.#####
```PUT ../api/lottery/iswinner```
Content-Type: application/json
Body / Content:
```
{
    "chances": 
    [
        {
            "values": 
            [
                {
                    "value": 68
                },
                {
                    "value": 21
                },
                {
                    "value": 33
                },
                {
                    "value": 87
                },
                {
                    "value": 61
                },
                {
                    "value": 67
                }
            ]
        },
        {
            "values": 
            [
                {
                    "value": 69
                },
                {
                    "value": 21
                },
                {
                    "value": 33
                },
                {
                    "value": 87
                },
                {
                    "value": 61
                },
                {
                    "value": 67
                }
            ]
        }
    ]
}
```
