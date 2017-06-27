# Change Log

All notable changes to this project will be documented in this file.

[LICENSE](LICENSE) - [README](README.md) - [CHANGELOG](CHANGELOG.md) 

## [0.3.4] - 26/06/2017 - [@emimontesdeoca](https://github.com/emimontesdeoca)
### Add
- Fixed tables in project.
- Added Profile page.
- Added Search page.

### Fixes
- Fixed some errors in code for project.
- Improvements in responsive in various views.
- Added correct pagetitle for each view.

## [0.3.3] - 02/06/2017 - [@emimontesdeoca](https://github.com/emimontesdeoca)
### Add
- Dashboard squares style.

### Fixes
- Changes to expiration date when confirming the registration and confirming project's invitations.

## [0.3.2] - 01/06/2017 - [@emimontesdeoca](https://github.com/emimontesdeoca)
### Add
- Email confirmation sent when register.
- User needs to confirm in order to actually register.
- Inviting people to project sends an email that has to be confirmed.
- Dashboard number are calculated from open task in all user projects.
- Added a class with constants that are being repeated a lot.
- Added exception treatment when user is trying to confirm and old invitation/confirmation.

## [0.3.1] - 31/05/2017 - [@emimontesdeoca](https://github.com/emimontesdeoca)
### Add
- Elements showing in project.
- Security measures for elements from other users.
- Collaborators integrated, works fine.
- Email notification when creating a project.
- Email notification when creating an element that is assigned to you.

### Fixes
- Update project system.
- Update element system.

## [0.3.0] - 30/05/2017 - [@emimontesdeoca](https://github.com/emimontesdeoca)
### Add
- AddElement fixed.
- ManageElement backend done.
- Better project task table.

## [0.2.8] - 22/05/2017 - [@emimontesdeoca](https://github.com/emimontesdeoca)
### Add
- AddElement view.
- ManageElement view.
- ManageProject finished.
- AddElement finished.

## [0.2.6] - 22/05/2017 - [@emimontesdeoca](https://github.com/emimontesdeoca)
### Add
- ManageProject backend.
- Coveralls.

## [0.2.5] - 21/05/2017 - [@emimontesdeoca](https://github.com/emimontesdeoca)
### Removed
- Docs clean.
- Tools clean.

## [0.2.4] - 19/05/2017 - [@emimontesdeoca](https://github.com/emimontesdeoca)
### Add
- New forms for ManageProject.

### Fixes
- Found a bug in Reponse.Redirect() with Sessions.
- Fixed buttons in Project.
- It's PROJECT not PROYECT, nice englando @emimontesdeoca.

## [0.2.3] - 18/05/2017 - [@emimontesdeoca](https://github.com/emimontesdeoca)
### Add
- Added fieldset & legend to AddProyect.
- Added fieldset & legend to ManageUser.
- Added social links to User.
- Added collaborators to addproyect
- Added webiste, repository and support link to AddProyect.
- Added public bool to user.
- Added information to project.
- Added ManageProject information in view.
- Added ManageProject backend.

### Fixes
- Column design on AddProject and Project fixed.

## [0.2.2] - 17/05/2017 - [@emimontesdeoca](https://github.com/emimontesdeoca)
### Add
- Added Last Modified datetime to user.
- Added Country/City/Postal code to user.
- Added Address to user.
- Added Summary to user.
- Added suppor to update the profile, everything but email (username).
- Added topbar dropdown for user.
- Added topbar dropdown for new things like proyects and etc.

### Changes
- Changed the way it loads Sessions in Proyets/User.

## [0.2.1] - 16/05/2017 - [@emimontesdeoca](https://github.com/emimontesdeoca)
### Add
- Proyect backend done.
- Add proyect backend done.
- Load proyects in sidebar done.
- Load proyect in proyect.aspx done.
- Added temporal favicon.
- Added security when a user tries to redirect to another user proyect.
- Added pagetitle for current views.
- Added header title for current views.

### Changes
- Changed ManageProyect.
- Changed AddProyect.
- Fixed mistake where users where decripting when trying to load, Sessions now keep encrypted.

### Remove
- TODO file, not being used at all.

## [0.2.0] - 15/05/2017 - [@emimontesdeoca](https://github.com/emimontesdeoca)
### Add
- Login view and backend done.
- Register view and backend done.
- Account view and backend done.

### Changes
- Changed style of templates.
- Refactor

## [0.1.2] - 12/05/2017 - [@emimontesdeoca](https://github.com/emimontesdeoca)
### Add
- Added atributes and methods to Elements.cs.
- Added atributes and methods to License.cs.
- Added atributes and methods to Template.cs.
- Added atributes and methods to Proyects.cs.
- Added atributes and methods to UserLicense.cs.
- Added atributes and methods to Elements.cs.
- Created Role.
- Added atributes and methods to Role.cs.
- Added atributes and methods to Users.cs.
- Added User assignation to elements.cs.

### Changes

- Better refactoring.
- Better crypto system.
- Better ID generator.

## [0.1.1] - 11/05/2017 - [@emimontesdeoca](https://github.com/emimontesdeoca)
### Added
- Modified folder structure
- Added .gitattributes
- Added aspx for Users.
- Added masterpage.
- Added aspx for Dashboard.
- Added aspx for Project.
- Created folder structure for every controller.
- Created class for every view.
- Added intial files security for user login/register.
- Added element, project views.
- Added licenses.
- Added notification in header for masterpage.
- Added userlicenses.

### Changes
- Changes to structure.

### Remove
- Removed pages for edit/delete element.
- Removed pages for edit/deleted project.

## [0.1.0] - 10/05/2017 - [@emimontesdeoca](https://github.com/emimontesdeoca)
### Added
- Structure for project.
- Created VS project.
- Added Travis-CLI.
- Created Changelog file.
- Created TODO file.
- Created MVC folders.
- Added views to project.
- Added CSS to project.

### Changed
- Still working on the main template for the project.
- Modified CSS & JS for project.
