
# NPOI - Tests
Test the NPOI Library


## Development
### Used components

* Logging - [log4net]
[documentation](documentation/log4net.md)


### Render README.md

```console
pandoc -f markdown -t html5 --standalone -o README.html .\README.md; start .\README.html
```
_**Hint**: You need [pandoc] installed for the above command_

[log4net]: https://logging.apache.org/log4net/
[pandoc]: https://pandoc.org/
