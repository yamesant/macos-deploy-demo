APP=HelloWorld.app
PROJECT=MacosDeployDemo.UI

mkdir $APP
mkdir $APP/Contents
mkdir $APP/Contents/MacOS
mkdir $APP/Contents/Resources

cp $PROJECT/Assets/icon.icns $APP/Contents/Resources/icon.icns
cp Info.plist $APP/Contents/Info.plist

dotnet publish -r osx-arm64 --configuration Release --self-contained
rm -r $APP/Contents/MacOS
mkdir $APP/Contents/MacOS
cp $PROJECT/bin/Release/net8.0/osx-arm64/publish/* $APP/Contents/MacOS/