<h1 align="center">Lovis</h1>

<p align="center">
    <a href="https://travis-ci.org/emimontesdeoca/lovis.svg">
        <img src="https://travis-ci.org/emimontesdeoca/lovis.svg?branch=master"
             alt="build status">
    </a>
    <a href="https://github.com/emimontesdeoca/Lovis/blob/master/CHANGELOG.md">
        <img src="https://img.shields.io/badge/changelog-link-brightgreen.svg"
             alt="build status">
    </a>
    <a href="https://www.paypal.com/cgi-bin/webscr?cmd=_s-xclick&hosted_button_id=UBYQDM59B3GCC">
        <img src="https://img.shields.io/badge/donate-PayPal-green.svg"
             alt="Donate a coffee!">
    </a>
    <a href="LICENSE">
        <img src="https://img.shields.io/github/license/mashape/apistatus.svg"
             alt="Donate a coffee!">
    </a>    
</p>

<p align="center">
📑 Project management tool with ticket system for teams or single developers.
</p>

## About

Lovis is a web application written in pure ASP.net that makes easier for teams to report issues, bugs, request to other developers. Just like Github's issue system but in a different way including all kind of email notifications and better security overall.

## Contributing

Even if Lovis is not MVC, I did serpate stuff in folders, this is the structure:

```

├───docs
├───src
│   ├───Controllers
│   │   ├───Const
│   │   ├───Dashboard
│   │   ├───Elements
│   │   ├───Email
│   │   ├───License
│   │   ├───Proyects
│   │   │   └───Templates
│   │   ├───Role
│   │   ├───UserLicense
│   │   │   └───Confirmation
│   │   └───Users
│   │       ├───Confirmation
│   │       ├───Login
│   │       └───Register
│   ├───Models
│   ├───Security
│   │   ├───IdGenerator
│   │   └───Users
│   └───Views
│       ├───Confirmation
│       ├───Dashboard
│       │   └───NewFolder1
│       ├───Element
│       ├───Error
│       ├───Login
│       ├───Profile
│       ├───Proyects
│       ├───Register
│       ├───Shared
│       │   └───Assets
│       │       ├───css
│       │       ├───icon
│       │       ├───img
│       │       └───js
│       └───User
└───tools
```

Any bug, issue, feature request or question, feel free to open a [ticket issue](https://github.com/emimontesdeoca/lovis/issues), if possible use proper labels.

## License

This project is licensed under the MIT License - see the [LICENSE](LICENSE) file for details
