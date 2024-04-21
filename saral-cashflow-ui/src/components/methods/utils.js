function showFadingAlert(message, type) {
  const alertPlaceholder = document.getElementById("liveAlertPlaceholder");
  const appendAlert = (message, type) => {
    const wrapper = document.createElement("div");
    wrapper.innerHTML = [
      `<div class="alert alert-${type} alert-dismissible mt-2 mb-2" role="alert">`,
      `   <div>${message}</div>`,
      '   <button type="button" class="btn-close" data-bs-dismiss="alert" aria-label="Close"></button>',
      "</div>",
    ].join("");

    alertPlaceholder.append(wrapper);

    setTimeout(() => {
      wrapper.parentNode.removeChild(wrapper); // Remove the wrapper after 1000ms
    }, 1000);
  };
  appendAlert(message, type);
}

export { showFadingAlert };
