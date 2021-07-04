# LiveMap #

A map combining static data plotted points with dynamic data pushed to a web page via websockets from a variety of devices, all channeled through a service bus and consumed then pushed by a server application

---
## Background : ##

I've had an idea for a wee while that I want to map how certain creatures have migrated and swept across the world over time, I love this idea for all creatures but mostly I want to know about cephlapods, the mad wee bastards. I have recently been entertaining a very similar idea in work, with a specific focus on live events and displaying said live events on a world map.
I think this is cool as fuck so I wanty make it

---
## Concept : ##

A simple React application which lays out a world map and allows the addition / subtraction of points on the map
This SPA will be connected to a .Net5 web API via Rest & SignalR 
I will also build an event pusher for testing purpoises 

---
## Implementation : ##

A react app hosting a world map  
A .Net5 web API with Get requests for static map data points  
A SignalR connection between the .Net5 API and React SPA which allows pushing of new events  
A method of publishing new events  
An Ability to display newly pubslihed events on react map  

---
## Bonus Points : ##

Inclusion of weather data  
Inclusion of any other locale data   
Usage of a service bus  
A UI for publishing new events  
Historical storage for new events  
Data point comparison tool  
CSS Fuckery 

---
## Super Bonus Points : ##

Ability to include IoT devices - this would take hings to the next fuckin level man  

## Architecture ##
---

<img src="resources\Architecture.svg">

---
## Credits : ##
As much as I would absolutely love to say "here mate am the best in the world at this shit", realistically this will - as per every project ever - be the product of a whole load of resource gathering n playdough-ing it into an angular project. As is the way.

This is a log of items watched or read which I've then implemented and bastardised for future reference.

```csharp OrderBy
return await creditList
    .OrderBy(x => x.Type.ArbitraryWeightValueThatIMadeUpToFormatTheTable)
    .ThenBy(x => x.TimeAccessedRelativeToProject)
    .ToListAsync();
```

|Type|Author|Gist|Areas Covered|Link|
|---|---|---|---|:---:|
|Documentation|Microsoft|Chat application using Signal R, .Net5 & React|SignalR Integration|[Cheers Mate](https://www.youtube.com/watch?v=nEQvA5HfEDE)|
|Documentation|Google|OpenWeatherMap Integration|Weather overlay, GoogleMap API|[Cheers Mate](https://github.com/google/maps-for-work-samples/blob/master/samples/maps/OpenWeatherMapLayer/OpenWeatherMapLayer.pdf)|
|Video|Leigh Halliday|Google Maps in React|React, GoogleMap API|[Cheers Mate](https://www.youtube.com/watch?v=Pf7g32CwX_s)|
|Video|Brad Traversy|Google Maps in React|React, GoogleMap API|[Cheers Mate](https://www.youtube.com/watch?v=ontX4zfVqK8)|

