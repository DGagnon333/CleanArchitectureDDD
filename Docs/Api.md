## Buber Dinner API

this api is used for authentification to BuberDinner and adding or listing users

### Method title

> Version history note.

Description of the method.

```js
POST {{host}}/auth/register
```

Supported attributes:

| Attribute                | Type     | Required | Description           |
|--------------------------|----------|----------|-----------------------|
| `firstName`              | string | yes      | first name |
| `lastName` | string | yes       | last name |
| `email`              | string | yes       | email address |
| `password`              | string | yes       | password |

If successful, returns [`200 ok`]
response attributes:

| Attribute                | Type     | Description           |
|--------------------------|----------|-----------------------|
| `id`              | string | id |
| `firstName`              | string | first name |
| `lastName`              | string | last name |
| `email`              | string | email |
| `token` **(JWT)** | string | a jason web token |

Example request:

```shell
curl --url 'http://localhost:5006/auth/register?firstname=Derick&lastName=Gagnon&email=derickGagnon@outlook.com&password=1234'
```

Example response:

```json
[
  {
  }
]
```