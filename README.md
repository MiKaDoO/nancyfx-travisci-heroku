Project configuration to use Travis and Heroku for build, tests and deploy NancyFx app.

Assumming you have [Travis](https://travis-ci.org/) and [Heroku](https://www.heroku.com/) accounts.

Create an empty app in Heroku. Add your app informations in the following files:

.travis.yml

```sh
[...]
deploy:
  provider: heroku
  buildpack: https://github.com/friism/heroku-buildpack-mono.git
  api_key: "[api-key]"
  app: [app-name]
```

HelloWorld/app.config

```sh
<appSettings>
    	<add key="host" value="[app-url]" />
</appSettings>
```

Create a repository on github and add it in Travis.

