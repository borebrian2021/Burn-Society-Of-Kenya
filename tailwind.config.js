module.exports = {
    content: [
        
        './Views/**/*.cshtml', // For MVC/Razor views
        './Pages/**/*.cshtml', // For Razor Pages (if applicable)
        './wwwroot/**/*.html', // Static HTML files (if any)
        './src/**/*.{html,js,ts,jsx,tsx}', // Add other relevant file types
        './wwwroot/**/*.css',
        // If you're using static HTML files
        './node_modules/flowbite/**/*.js',  // Include Flowbite components
    ],
    theme: {
        extend: {},
    },
    plugins: [
        require('flowbite/plugin'),

    ],
};
