window.addEventListener('load', (event) => {
    console.log('page is fully loaded');
    document.cookie = "csb=ready";
    alert("Client Side Blazor is now available refresh to use")
});